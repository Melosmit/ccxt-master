namespace ccxt.pro;

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code


public partial class binanceusdm { public binanceusdm(object args = null) : base(args) { } }
public partial class binanceusdm : binance
{
    public override object describe()
    {
        return this.deepExtend(base.describe(), new Dictionary<string, object>() {
            { "id", "binanceusdm" },
            { "name", "Binance USDⓈ-M" },
            { "urls", new Dictionary<string, object>() {
                { "logo", "https://user-images.githubusercontent.com/1294454/117738721-668c8d80-b205-11eb-8c49-3fad84c4a07f.jpg" },
                { "doc", "https://developers.binance.com/en" },
            } },
            { "options", new Dictionary<string, object>() {
                { "fetchMarkets", new List<object>() {"linear"} },
                { "defaultSubType", "linear" },
            } },
            { "exceptions", new Dictionary<string, object>() {
                { "exact", new Dictionary<string, object>() {
                    { "-5021", typeof(InvalidOrder) },
                    { "-5022", typeof(InvalidOrder) },
                    { "-5028", typeof(InvalidOrder) },
                } },
            } },
        });
    }
}