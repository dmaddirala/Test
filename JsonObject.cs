namespace QnA
{
    class RootObject
    {
        public string status { get; set; }

        public Datum[] data;
    }

    class Datum
    {
        public string id { get; set; }
        public string employees_name { get; set; }
        public string employees_salary { get; set; }
        public string employees_age { get; set; }
        public string employees_image { get; set; }


    }
}