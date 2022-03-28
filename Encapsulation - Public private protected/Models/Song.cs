using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encapsulation___Public_private_protected.Models
{
    class Song
    {//Song class-ı olsun. Song-un Name, Genre, Singer(agregation) prop-ları olsun. Name max 100 uzunluqda set oluna bilər.
     //Genre yalnız "Pop", "Rock", "Jazz", "Techno" bu value-lardan biri ola bilər. Məsələn  "Classic" ola bilməz,
     //yalnız göstərilənlərdən biri set olunmalıdır.

        private string _name;
        private string _genre;
        private Singer _singer;
        //private double _ratings;
        private int[] Ratings = new int[0];
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value.Length <= 100)
                {
                    _name = value;
                }
                else Console.WriteLine("100den boyukdur");
            }
        }
        public string Genre
        {
            get
            {
                return _genre;
            }
            set
            {
                if ((value=="Jazz")|| (value == "Pop")|| (value =="Rock")||(value == "Techno"))
                {
                    _genre = value;
                }
                else Console.WriteLine("Hata");
            }
        }
        public Singer Singer
        {
            get
            {
                return _singer;
            }
            set
            {
                _singer = value;
            }
        }
        //public double Ratings 
        //{
        //    get
        //    {
        //        return _ratings;
        //    }
        //    set
        //    {
        //        if (value >= 0 && value <= 10)
        //        {
        //            _ratings = value;
        //        }
        //    }
        //}


        //Song-un rating-ləri olsun. AddRating, GetAverageRating metodları ilə funksionallıq təmin olunsun.

        public void AddRating(int rating)
        {
            if (rating >= 0 && rating <= 10)
            {
                Array.Resize(ref Ratings, Ratings.Length + 1);
                Ratings[Ratings.Length - 1] = rating;
            }
            
           
            
        }
        public double GetAverageRating()
        {
            return Ratings.Average();
        }
    }
}
