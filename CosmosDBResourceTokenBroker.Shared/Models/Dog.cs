using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosDBResourceTokenBroker.Shared.Models
{
    public class GalleryTile : TypedDocument<GalleryTile>
    {
        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("display_tabs")]
        public string Display_tabs { get; set; }

		[JsonProperty("TableauID")]
        public string TableauID { get; set; }

        [JsonProperty("UserName")]
        public string UserName { get; set; }

		[JsonProperty("ChartSourceLink")]
        public string ChartSourceLink { get; set; }

        [JsonProperty("ChartThumbLink")]
        public string ChartThumbLink { get; set; }

		[JsonProperty("favorited")]
        public string Favorited { get; set; }

        [JsonProperty("filterContentType")]
        public string FilterContentType { get; set; }

		[JsonProperty("chartDescriptionText")]
        public string ChartDescriptionText { get; set; }

        [JsonProperty("filterContentGroup")]
        public string FilterContentGroup { get; set; }

		[JsonProperty("viewCount")]
        public string ViewCount { get; set; }

        [JsonProperty("nviews")]
        public string Nviews { get; set; }

		[JsonProperty("SelfService")]
        public string SelfService { get; set; }

        [JsonProperty("ChartPreviewStatus")]
        public string ChartPreviewStatus { get; set; }

		[JsonProperty("chartInfo")]
        public string ChartInfo { get; set; }

        [JsonProperty("chartUse")]
        public string ChartUse { get; set; }

    }
}
