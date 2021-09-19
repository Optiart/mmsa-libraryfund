using Domain.Enum;
using Domain.Models.Funds;
using System;
using System.Collections.Generic;

namespace Domain.Builders.Funds
{
    public abstract class FundBuilder<TFund, TBuilder> 
        where TFund : Fund, new()
        where TBuilder: FundBuilder<TFund, TBuilder>
    {
        protected TFund Fund;
        protected TBuilder BuilderInstance;

        public FundBuilder() => BuilderInstance = (TBuilder)this;

        public TBuilder New()
        {
            Fund = new();
            return BuilderInstance;
        }

        public TBuilder WithBasicInfo(uint id, string name, DateTime publishDate, FundCategoryEnum category)
        {
            Fund.Id = id;
            Fund.Name = name ?? throw new ArgumentNullException(nameof(name));

            if (publishDate == default)
            {
                throw new ArgumentException("Invalid publish date", nameof(publishDate));
            }
            Fund.PublishDate = publishDate;
            Fund.Category = category;

            return BuilderInstance;
        }

        public TBuilder WithAuthors(ICollection<Author> authors)
        {
            Fund.Authors = authors;
            return BuilderInstance;
        }

        public TBuilder WithCopies(ICollection<FundCopy> copies)
        {
            Fund.Copies = copies;
            return BuilderInstance;
        }

        public TFund Build() => Fund;
    }
}
