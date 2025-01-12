﻿namespace KevinZonda.Health.DepressionAnxietyQuiz.Library.Model
{
    public class ValueModel
    {
        public string Text { get; set; }
        public ValueItem[] Values { get; set; }
    }

    public enum ValueType
    {
        Score,
        Result,
        Link
    }

    public class ValueItem
    {
        public ValueType Type { get; set; } = ValueType.Score;
        public int Value { get; set; }

        public static ValueItem CreateScoreItem(int value)
            => new ValueItem()
            {
                Value = value,
            };

        public static ValueItem CreateLinkItem(int value)
            => new ValueItem()
            {
                Type = ValueType.Link,
                Value = value,
            };

        public static ValueItem CreateResultItem(int value)
            => new ValueItem()
            {
                Type = ValueType.Result,
                Value = value,
            };
    }
}