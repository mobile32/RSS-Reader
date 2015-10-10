﻿using PropertyChanged;
namespace RSS_Reader.ViewModel.Dto
{
    [ImplementPropertyChanged]
    public class News
    {
        public string Title { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string LinkImage { get; set; }
        public string LinkNews { get; set; }
        public string Category { get; set; }
    }
}