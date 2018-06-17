﻿using Visitor.Books;
using Visitor.Games;
using Visitor.Movies;

namespace Visitor.Visitors.Prices
{
    public class BuyTwoGetOneFreeVisitor : IPriceVisitor
    {
        public double Sum { get; private set; }
        public int AmmountBooks { get; private set; }
        public int AmmountGames { get; private set; }

        public void Visit(Book book)
        {
            AmmountBooks++;
            if (AmmountBooks != 3) Sum += book.PrizePerItem;
        }

        public void Visit(Movie movie)
        {
            Sum += movie.PrizePerItem;
        }

        public void Visit(Game game)
        {
            AmmountGames++;
            if (AmmountGames != 3) Sum += game.PrizePerItem;
        }
    }
}