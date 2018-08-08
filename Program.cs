using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp.SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PortfolioContext())
            {
                CreateAndPopulateTables(db);
                UpdateReturnTables(db);
                db.SaveChanges();
            }
        }

        private static void CreateAndPopulateTables(PortfolioContext db)
        {
            //initialize stock
            Stock aaplStock = new Stock
            {
                StockId = 1,
                Name = "AAPL",
                LatestPrice = 209.0600d
            };

            Stock amznStock = new Stock
            {
                StockId = 2,
                Name = "AMZN",
                LatestPrice = 1847.6801d
            };

            Stock cmcsaStock = new Stock
            {
                StockId = 3,
                Name = "CMCSA",
                LatestPrice = 35.3100d
            };


            Stock cscoStock = new Stock
            {
                StockId = 4,
                Name = "CSCO",
                LatestPrice = 43.2900d
            };

            Stock intcStock = new Stock
            {
                StockId = 5,
                Name = "INTC",
                LatestPrice = 49.2900d
            };

            Stock msftStock = new Stock
            {
                StockId = 6,
                Name = "MSFT",
                LatestPrice = 108.1300d
            };

            Stock nvdaStock = new Stock
            {
                StockId = 7,
                Name = "NVDA",
                LatestPrice = 254.0900d
            };

            Stock shpgStock = new Stock
            {
                StockId = 8,
                Name = "SHPG",
                LatestPrice = 173.3000d
            };

            db.Stocks.AddRange(
             aaplStock,
             amznStock,
             cmcsaStock,
             cscoStock,
             intcStock,
             msftStock,
             nvdaStock,
             shpgStock);

            //initialize portfolio
            Portfolio pchangPortfolio = new Portfolio
            {
                PortfolioId = 1,
                Owner = "pchang"
            };

            Portfolio demoPortfolio = new Portfolio
            {
                PortfolioId = 2,
                Owner = "demo"
            };

            db.Portfolios.AddRange(pchangPortfolio,
             demoPortfolio
            );


            //initialize portfolio allocation
            //initialize pchang portfolio
            PortfolioAllocation pchangAapl = new PortfolioAllocation
            {
                Id = 1,
                PortfolioId = 1,
                StockId = 1,
                Qty = 1
            };

            PortfolioAllocation pchangAmzn = new PortfolioAllocation
            {
                Id = 2,
                PortfolioId = 1,
                StockId = 2,
                Qty = 1
            };

            PortfolioAllocation pchangCmcsa = new PortfolioAllocation
            {
                Id = 3,
                PortfolioId = 1,
                StockId = 3,
                Qty = 1
            };

            PortfolioAllocation pchangCsco = new PortfolioAllocation
            {
                Id = 4,
                PortfolioId = 1,
                StockId = 4,
                Qty = 1
            };

            //initialize demo portfolio 
            PortfolioAllocation demoIntc = new PortfolioAllocation
            {
                Id = 5,
                PortfolioId = 2,
                StockId = 5,
                Qty = 1
            };

            PortfolioAllocation demoMsft = new PortfolioAllocation
            {
                Id = 6,
                PortfolioId = 2,
                StockId = 6,
                Qty = 1
            };
            PortfolioAllocation demoNvda = new PortfolioAllocation
            {
                Id = 7,
                PortfolioId = 2,
                StockId = 7,
                Qty = 1
            };
            PortfolioAllocation demoShpg = new PortfolioAllocation
            {
                Id = 8,
                PortfolioId = 2,
                StockId = 8,
                Qty = 1
            };

            db.PortfolioAllocations.AddRange(
             pchangAapl,
             pchangAmzn,
             pchangCmcsa,
             pchangCsco,
             demoIntc,
             demoMsft,
             demoNvda,
             demoShpg
            );

            //initialize aapl price records
            StockPriceRecord aaplRecord1 = new StockPriceRecord
            {
                Id = 1,
                StockId = 1,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 209.06
            };

            StockPriceRecord aaplRecord2 = new StockPriceRecord
            {
                Id = 2,
                StockId = 1,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 209.06
            };

            StockPriceRecord aaplRecord3 = new StockPriceRecord
            {
                Id = 3,
                StockId = 1,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 209.06
            };

            StockPriceRecord aaplRecord4 = new StockPriceRecord
            {
                Id = 4,
                StockId = 1,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 209.06
            };

            StockPriceRecord aaplRecord5 = new StockPriceRecord
            {
                Id = 5,
                StockId = 1,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 209.06
            };

            //initialize amzn price records
            StockPriceRecord amznRecord1 = new StockPriceRecord
            {
                Id = 6,
                StockId = 2,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 1847.6801
            };

            StockPriceRecord amznRecord2 = new StockPriceRecord
            {
                Id = 7,
                StockId = 2,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 1845.87
            };

            StockPriceRecord amznRecord3 = new StockPriceRecord
            {
                Id = 8,
                StockId = 2,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 1845.65
            };

            StockPriceRecord amznRecord4 = new StockPriceRecord
            {
                Id = 9,
                StockId = 2,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 1846.17
            };

            StockPriceRecord amznRecord5 = new StockPriceRecord
            {
                Id = 10,
                StockId = 2,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 1845.46
            };

            //initialize cmcsa price records
            StockPriceRecord cmcsaRecord1 = new StockPriceRecord
            {
                Id = 11,
                StockId = 3,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 35.31
            };

            StockPriceRecord cmcsaRecord2 = new StockPriceRecord
            {
                Id = 12,
                StockId = 3,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 35.3
            };

            StockPriceRecord cmcsaRecord3 = new StockPriceRecord
            {
                Id = 13,
                StockId = 3,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 35.34
            };

            StockPriceRecord cmcsaRecord4 = new StockPriceRecord
            {
                Id = 14,
                StockId = 3,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 35.365
            };

            StockPriceRecord cmcsaRecord5 = new StockPriceRecord
            {
                Id = 15,
                StockId = 3,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 35.355
            };

            //initialize csco price records
            StockPriceRecord cscoRecord1 = new StockPriceRecord
            {
                Id = 16,
                StockId = 4,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 43.29
            };

            StockPriceRecord cscoRecord2 = new StockPriceRecord
            {
                Id = 17,
                StockId = 4,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 43.27
            };

            StockPriceRecord cscoRecord3 = new StockPriceRecord
            {
                Id = 18,
                StockId = 4,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 43.305
            };

            StockPriceRecord cscoRecord4 = new StockPriceRecord
            {
                Id = 19,
                StockId = 4,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 43.3213
            };

            StockPriceRecord cscoRecord5 = new StockPriceRecord
            {
                Id = 20,
                StockId = 4,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 43.365
            };

            //initialize intc price records
            StockPriceRecord intcRecord1 = new StockPriceRecord
            {
                Id = 21,
                StockId = 5,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 49.29
            };

            StockPriceRecord intcRecord2 = new StockPriceRecord
            {
                Id = 22,
                StockId = 5,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 49.24
            };

            StockPriceRecord intcRecord3 = new StockPriceRecord
            {
                Id = 23,
                StockId = 5,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 49.22
            };

            StockPriceRecord intcRecord4 = new StockPriceRecord
            {
                Id = 24,
                StockId = 5,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 49.22
            };

            StockPriceRecord intcRecord5 = new StockPriceRecord
            {
                Id = 25,
                StockId = 5,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 49.2123
            };

            //initialize msft price records
            StockPriceRecord msftRecord1 = new StockPriceRecord
            {
                Id = 26,
                StockId = 6,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 108.13
            };

            StockPriceRecord msftRecord2 = new StockPriceRecord
            {
                Id = 27,
                StockId = 6,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 108.05
            };

            StockPriceRecord msftRecord3 = new StockPriceRecord
            {
                Id = 28,
                StockId = 6,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 108.09
            };

            StockPriceRecord msftRecord4 = new StockPriceRecord
            {
                Id = 29,
                StockId = 6,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 108.095
            };

            StockPriceRecord msftRecord5 = new StockPriceRecord
            {
                Id = 30,
                StockId = 6,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 108.05
            };

            //initialize nvda price records
            StockPriceRecord nvdaRecord1 = new StockPriceRecord
            {
                Id = 31,
                StockId = 7,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 254.09
            };

            StockPriceRecord nvdaRecord2 = new StockPriceRecord
            {
                Id = 32,
                StockId = 7,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 253.99
            };

            StockPriceRecord nvdaRecord3 = new StockPriceRecord
            {
                Id = 33,
                StockId = 7,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 253.83
            };

            StockPriceRecord nvdaRecord4 = new StockPriceRecord
            {
                Id = 34,
                StockId = 7,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 253.82
            };

            StockPriceRecord nvdaRecord5 = new StockPriceRecord
            {
                Id = 35,
                StockId = 7,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 254
            };

            //initialize shpg price records
            StockPriceRecord shpgRecord1 = new StockPriceRecord
            {
                Id = 36,
                StockId = 8,
                Datetime = new DateTime(2018, 08, 04, 16, 0, 0),
                Price = 173.3
            };

            StockPriceRecord shpgRecord2 = new StockPriceRecord
            {
                Id = 37,
                StockId = 8,
                Datetime = new DateTime(2018, 08, 04, 15, 55, 0),
                Price = 173.16
            };

            StockPriceRecord shpgRecord3 = new StockPriceRecord
            {
                Id = 38,
                StockId = 8,
                Datetime = new DateTime(2018, 08, 04, 15, 50, 0),
                Price = 173.055
            };

            StockPriceRecord shpgRecord4 = new StockPriceRecord
            {
                Id = 39,
                StockId = 8,
                Datetime = new DateTime(2018, 08, 04, 15, 45, 0),
                Price = 173.03
            };

            StockPriceRecord shpgRecord5 = new StockPriceRecord
            {
                Id = 40,
                StockId = 8,
                Datetime = new DateTime(2018, 08, 04, 15, 40, 0),
                Price = 172.96
            };

            db.PriceRecords.AddRange(
             aaplRecord1,
             aaplRecord2,
             aaplRecord3,
             aaplRecord4,
             aaplRecord5,

             amznRecord1,
             amznRecord2,
             amznRecord3,
             amznRecord4,
             amznRecord5,

             cmcsaRecord1,
             cmcsaRecord2,
             cmcsaRecord3,
             cmcsaRecord4,
             cmcsaRecord5,

             cscoRecord1,
             cscoRecord2,
             cscoRecord3,
             cscoRecord4,
             cscoRecord5,

             intcRecord1,
             intcRecord2,
             intcRecord3,
             intcRecord4,
             intcRecord5,

             msftRecord1,
             msftRecord2,
             msftRecord3,
             msftRecord4,
             msftRecord5,

             nvdaRecord1,
             nvdaRecord2,
             nvdaRecord3,
             nvdaRecord4,
             nvdaRecord5,

             shpgRecord1,
             shpgRecord2,
             shpgRecord3,
             shpgRecord4,
             shpgRecord5
            );

            db.SaveChanges();
        }

        static void UpdateReturnTables(PortfolioContext db)
        {
            foreach (var Stock in db.Stocks)
            {
                List<StockPriceRecord> priceRecords = Stock.StockPriceRecords.OrderBy(pr => pr.Datetime).ToList();
                IEnumerable<StockMinuteReturn> mr =
                 priceRecords.Select((pr, index) => new StockMinuteReturn()
                 {
                     DateTime = pr.Datetime,
                     StockId = pr.StockId,
                     Return = index > 0 ? pr.Price - priceRecords[index - 1].Price : 0
                 });

                IEnumerable<StockHourlyReturn> hr =
                 priceRecords.Select((pr, index) => new StockHourlyReturn()
                 {
                     DateTime = pr.Datetime,
                     StockId = pr.StockId,
                     Return = index > 1 ? pr.Price - priceRecords[index - 2].Price : 0
                 });

                db.MinuteReturns.AddRange(mr);
                db.HourlyReturns.AddRange(hr);
            }
            db.SaveChanges();
        }
    }
}