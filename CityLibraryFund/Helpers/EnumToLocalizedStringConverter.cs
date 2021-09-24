using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CityLibraryFund.Helpers
{
    public static class EnumToLocalizedStringConverter
    {
        public static Dictionary<UserCategoryEnum, string> UserCategoryToString = new Dictionary<UserCategoryEnum, string>
        {
            { UserCategoryEnum.Employee, "Співробітники" },
            { UserCategoryEnum.Lecturer, "Викладачі" },
            { UserCategoryEnum.Librarian, "Бібліотекарі" },
            { UserCategoryEnum.Other, "Інша категорія" },
            { UserCategoryEnum.Retiree, "Пенсіонери" },
            { UserCategoryEnum.SchoolChild, "Школярі" },
            { UserCategoryEnum.Scientist, "Вчені" },
            { UserCategoryEnum.Student, "Студенти" }
        };

        public static Dictionary<FundEntityEnum, string> FundEntityToString = new Dictionary<FundEntityEnum, string>
        {
            { FundEntityEnum.Book, "Книга" },
            { FundEntityEnum.Journal, "Журнал" },
            { FundEntityEnum.Newspaper, "Газета" },
            { FundEntityEnum.Other, "Інше" }
        };


        public static Dictionary<FundCategoryEnum, string> FundCategoryToString = new Dictionary<FundCategoryEnum, string>
        {
            { FundCategoryEnum.Summery, "Реферат" },
            { FundCategoryEnum.Story, "Розповіді" },
            { FundCategoryEnum.ReportCollection, "Збірник доповідей" },
            { FundCategoryEnum.Poetry, "Поезія" },
            { FundCategoryEnum.Novel, "Новели" },
            { FundCategoryEnum.News, "Новини" },
            { FundCategoryEnum.Manual, "Підручник" },
            { FundCategoryEnum.Dissertation, "Дисертація" },
            { FundCategoryEnum.Article, "Стаття" },
            { FundCategoryEnum.Poetry, "Поезія" },
            { FundCategoryEnum.Abstracts, "Тези доповідей" }
        };

        public static IEnumerable<string> GetEnumValuesLocalized<T>(IDictionary<T, string> dictionary)
            where T : Enum => GetEnumValues<T>()
                .Select(e => dictionary.TryGetValue(e, out var value) ? value : "")
                .Where(s => !string.IsNullOrEmpty(s));

        public static T GetEnumFromLocalizedString<T>(IDictionary<T, string> dictionary, string value)
            where T : Enum => dictionary
                .FirstOrDefault(kvp => kvp.Value.Equals(value, StringComparison.InvariantCultureIgnoreCase)).Key;

        public static IReadOnlyList<T> GetEnumValues<T>()
            where T : Enum => Enum.GetValues(typeof(T)) as T[];
    }
}
