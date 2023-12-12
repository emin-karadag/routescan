﻿using Routescan.Core.Converters;
using Routescan.Core.Models;
using System.Text.Json.Serialization;

namespace Routescan.Models.Accounts
{
    public class InternalTransactionsModel : RoutescanBaseModel, IRoutescanModel
    {
        [JsonPropertyName("status")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; } = "";

        [JsonPropertyName("result")]
        public List<InternalTransactionsData>? Result { get; set; }
    }

    public partial class InternalTransactionsData
    {
        [JsonPropertyName("blockNumber")]
        [JsonConverter(typeof(StringToLongConvertor))]
        public long BlockNumber { get; set; }

        [JsonPropertyName("timeStamp")]
        [JsonConverter(typeof(StringToDateTimeConvertor))]
        public DateTime TimeStamp { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; } = "";

        [JsonPropertyName("from")]
        public string From { get; set; } = "";

        [JsonPropertyName("to")]
        public string To { get; set; } = "";

        [JsonPropertyName("value")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Value { get; set; }

        [JsonPropertyName("contractAddress")]
        public string ContractAddress { get; set; } = "";

        [JsonPropertyName("input")]
        public string Input { get; set; } = "";

        [JsonPropertyName("type")]
        public string Type { get; set; } = "";

        [JsonPropertyName("gas")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal Gas { get; set; }

        [JsonPropertyName("gasUsed")]
        [JsonConverter(typeof(StringToDecimalConvertor))]
        public decimal GasUsed { get; set; }

        [JsonPropertyName("traceId")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int TraceId { get; set; }

        [JsonPropertyName("isError")]
        [JsonConverter(typeof(StringToIntConvertor))]
        public int IsError { get; set; }

        [JsonPropertyName("errCode")]
        public string ErrCode { get; set; } = "";
    }
}
