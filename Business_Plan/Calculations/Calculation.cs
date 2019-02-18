using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Business_Plan.Models;
//get curent exchange rate from option
//fix k+1
namespace Business_Plan.Calculations
{
    public class Calculation
    {
        private FOBDto tempFob;
        private IEnumerable<StockDto> tempStocks;
        private IEnumerable<ProdutBasicsUnitCostsDto> tempProductCosts;
        private IEnumerable<TotalCostOfProductDto> tempTotal;
        const double vat = 0.15;
        const int months = 12;

        public FOBDto CalcFob(FOBDto stocks)
        {
            tempFob = stocks;
            tempFob.CurrentExchangeRate = 12.02;
            tempFob.TotalRandsFOB = tempFob.FobOfProduct * tempFob.CurrentExchangeRate;
            tempFob.LandedCost = tempFob.TotalRandsFOB + tempFob.ShippingCost + tempFob.Duty + tempFob.ApplicationFee;
            tempFob.Vat = vat * tempFob.LandedCost;
            tempFob.LandedVat = tempFob.LandedCost + (vat * tempFob.LandedCost);
            return tempFob;
        }

        public IEnumerable<StockDto> CalcStock(IEnumerable<StockDto> stocks)
        {
            tempStocks = stocks;

            for (int k = 0; k < months; k++)
            {
                if (k == 0)
                {
                    tempStocks.ElementAt(k).UnitOpeningStock = 0;
                    tempStocks.ElementAt(k).UnitClosingStock = tempStocks.ElementAt(k).UnitOpeningStock + tempStocks.ElementAt(k).UnitPurshases - tempStocks.ElementAt(k).UnitSales;
                    tempStocks.ElementAt(k).WeeksForward = tempStocks.ElementAt(k + 1).UnitSales + tempStocks.ElementAt(k + 2).UnitSales;
                    tempStocks.ElementAt(k).OverUnderStock = tempStocks.ElementAt(k).UnitClosingStock - tempStocks.ElementAt(k).WeeksForward;
                }//if
                else
                {
                    tempStocks.ElementAt(k).UnitOpeningStock = tempStocks.ElementAt(k - 1).UnitClosingStock;
                    tempStocks.ElementAt(k).UnitClosingStock = tempStocks.ElementAt(k).UnitOpeningStock + tempStocks.ElementAt(k).UnitPurshases - tempStocks.ElementAt(k).UnitSales;
                    tempStocks.ElementAt(k).WeeksForward = tempStocks.ElementAt(k + 1).UnitSales + tempStocks.ElementAt(k + 2).UnitSales;
                    tempStocks.ElementAt(k).OverUnderStock = tempStocks.ElementAt(k).UnitClosingStock - tempStocks.ElementAt(k).WeeksForward;
                }
            }

            return tempStocks;
        }

        public IEnumerable<ProdutBasicsUnitCostsDto> ProductUnitCosts(IEnumerable<ProdutBasicsUnitCostsDto> produtBasicsUnitCosts)
        {
            tempProductCosts = produtBasicsUnitCosts;
            double LandedVat = tempFob.LandedVat;
            var incVat = (vat * 100) + 100;

            for (int k = 0; k < months; k++)
            {
                tempProductCosts.ElementAt(k).UnitCostWithVat = LandedVat;
                tempProductCosts.ElementAt(k).UnitCostNoVat = (tempProductCosts.ElementAt(k).UnitCostWithVat / incVat) * 100;
                tempProductCosts.ElementAt(k).UnitSellNoVat = (tempProductCosts.ElementAt(k).UnitSellWithVat / incVat) * 100;
                tempProductCosts.ElementAt(k).MarginPercentage = (tempProductCosts.ElementAt(k).UnitSellNoVat - tempProductCosts.ElementAt(k).UnitCostNoVat) / (tempProductCosts.ElementAt(k).UnitSellNoVat * 100);
                tempProductCosts.ElementAt(k).MaringRands = tempProductCosts.ElementAt(k).UnitSellNoVat - tempProductCosts.ElementAt(k).UnitCostNoVat;
            }
            return tempProductCosts;
        }

        public IEnumerable<TotalCostOfProductDto> TotalCostOfProducts(IEnumerable<StockDto> stock, IEnumerable<ProdutBasicsUnitCostsDto> produtBasics)
        {
            tempTotal = new List<TotalCostOfProductDto>();

            for (int k = 0; k < months; k++)
            {
                tempTotal.ElementAt(k).PurchasesRandsNoVat = stock.ElementAt(k).UnitPurshases * produtBasics.ElementAt(k).UnitCostNoVat;
                tempTotal.ElementAt(k).SalesCostRandsNoVat = stock.ElementAt(k).UnitSales * produtBasics.ElementAt(k).UnitCostNoVat;
                tempTotal.ElementAt(k).SalesSellingRandsNoVar = stock.ElementAt(k).UnitSales * produtBasics.ElementAt(k).UnitCostNoVat;
                tempTotal.ElementAt(k).MarginRands = tempTotal.ElementAt(k).SalesSellingRandsNoVar - tempTotal.ElementAt(k).SalesCostRandsNoVat;
                tempTotal.ElementAt(k).StockOnHandNoVat = stock.ElementAt(k).UnitClosingStock * produtBasics.ElementAt(k).UnitCostNoVat;

            }
            return tempTotal;
        }
    }
}
