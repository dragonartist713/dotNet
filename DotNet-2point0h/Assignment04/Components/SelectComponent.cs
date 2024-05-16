using System.Text.Json;
using System;
using System.IO;
using Interfaces;
using Models;

namespace Components{
    public class SelectComponent : BaseWebComponent{
        static readonly string SelectId = "tv-show-select";

        List<TvShow> tvShowList = new List<TvShow>();


        public SelectComponent(List<TvShow> tvShowList){

        }

        public override string GenerateHtml(){
            List<string> selectOptions = new List<string>();

            string select = @"<div class='flex justify-center bg-white mt-24'>
          <select id='tv-show-select' class='bg-gray-50 w-1/4 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block p-2.5 dark:bg-gray-700 dark:border-gray-600 dark:placeholder-gray-400 dark:text-white dark:focus:ring-blue-500 dark:focus:border-blue-500'>";

            foreach (TvShow show in tvShowList){
                select += $"<option value={show.Id}>{show.Name}</option>"
            }

           select += @"</select>
          <span class='ml-4'>
          <button type='button' class='btn btn-primary' style='background-color: #007bff !important;' onclick='getValue()'>Select</button>
          </span>
        </div>";
            return select;
        }
    }
}