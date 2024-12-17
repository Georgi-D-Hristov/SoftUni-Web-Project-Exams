namespace DeskMarket.Common
{
    public static class DataConstants
    {
        public const int CategoryNameMaxLength = 20;
        public const int CategoryNameMinLength = 3;

        public const int ProductNameMaxLength = 60;
        public const int ProductNameMinLength = 2;

        public const int DescriptionMaxLength = 250;
        public const int DescriptionMinLength = 10;

        public const decimal MaxPrice = 1.00m;
        public const decimal MinPrice = 3000.00m;

        public const string AddedOnFormat = "dd-MM-yyyy";
        public const string AddedOnPattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-(\d{4})$";


    }
}