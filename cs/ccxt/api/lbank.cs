// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class lbank : Exchange
{
    public lbank (object args = null): base(args) {}

    public async Task<object> spotPublicGetCurrencyPairs (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetCurrencyPairs",parameters);
    }

    public async Task<object> spotPublicGetAccuracy (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetAccuracy",parameters);
    }

    public async Task<object> spotPublicGetUsdToCny (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetUsdToCny",parameters);
    }

    public async Task<object> spotPublicGetWithdrawConfigs (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetWithdrawConfigs",parameters);
    }

    public async Task<object> spotPublicGetTimestamp (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTimestamp",parameters);
    }

    public async Task<object> spotPublicGetTicker24hr (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTicker24hr",parameters);
    }

    public async Task<object> spotPublicGetTicker (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTicker",parameters);
    }

    public async Task<object> spotPublicGetDepth (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetDepth",parameters);
    }

    public async Task<object> spotPublicGetIncrDepth (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetIncrDepth",parameters);
    }

    public async Task<object> spotPublicGetTrades (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetTrades",parameters);
    }

    public async Task<object> spotPublicGetKline (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetKline",parameters);
    }

    public async Task<object> spotPublicGetSupplementSystemPing (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetSupplementSystemPing",parameters);
    }

    public async Task<object> spotPublicGetSupplementIncrDepth (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetSupplementIncrDepth",parameters);
    }

    public async Task<object> spotPublicGetSupplementTrades (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetSupplementTrades",parameters);
    }

    public async Task<object> spotPublicGetSupplementTickerPrice (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetSupplementTickerPrice",parameters);
    }

    public async Task<object> spotPublicGetSupplementTickerBookTicker (object parameters = null)
    {
        return await this.callAsync ("spotPublicGetSupplementTickerBookTicker",parameters);
    }

    public async Task<object> spotPublicPostSupplementSystemStatus (object parameters = null)
    {
        return await this.callAsync ("spotPublicPostSupplementSystemStatus",parameters);
    }

    public async Task<object> spotPrivatePostUserInfo (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostUserInfo",parameters);
    }

    public async Task<object> spotPrivatePostSubscribeGetKey (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubscribeGetKey",parameters);
    }

    public async Task<object> spotPrivatePostSubscribeRefreshKey (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubscribeRefreshKey",parameters);
    }

    public async Task<object> spotPrivatePostSubscribeDestroyKey (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSubscribeDestroyKey",parameters);
    }

    public async Task<object> spotPrivatePostGetDepositAddress (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostGetDepositAddress",parameters);
    }

    public async Task<object> spotPrivatePostDepositHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostDepositHistory",parameters);
    }

    public async Task<object> spotPrivatePostCreateOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCreateOrder",parameters);
    }

    public async Task<object> spotPrivatePostBatchCreateOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostBatchCreateOrder",parameters);
    }

    public async Task<object> spotPrivatePostCancelOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCancelOrder",parameters);
    }

    public async Task<object> spotPrivatePostCancelClientOrders (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostCancelClientOrders",parameters);
    }

    public async Task<object> spotPrivatePostOrdersInfo (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostOrdersInfo",parameters);
    }

    public async Task<object> spotPrivatePostOrdersInfoHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostOrdersInfoHistory",parameters);
    }

    public async Task<object> spotPrivatePostOrderTransactionDetail (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostOrderTransactionDetail",parameters);
    }

    public async Task<object> spotPrivatePostTransactionHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostTransactionHistory",parameters);
    }

    public async Task<object> spotPrivatePostOrdersInfoNoDeal (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostOrdersInfoNoDeal",parameters);
    }

    public async Task<object> spotPrivatePostWithdraw (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostWithdraw",parameters);
    }

    public async Task<object> spotPrivatePostWithdrawCancel (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostWithdrawCancel",parameters);
    }

    public async Task<object> spotPrivatePostWithdraws (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostWithdraws",parameters);
    }

    public async Task<object> spotPrivatePostSupplementUserInfo (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementUserInfo",parameters);
    }

    public async Task<object> spotPrivatePostSupplementWithdraw (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementWithdraw",parameters);
    }

    public async Task<object> spotPrivatePostSupplementDepositHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementDepositHistory",parameters);
    }

    public async Task<object> spotPrivatePostSupplementWithdraws (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementWithdraws",parameters);
    }

    public async Task<object> spotPrivatePostSupplementGetDepositAddress (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementGetDepositAddress",parameters);
    }

    public async Task<object> spotPrivatePostSupplementAssetDetail (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementAssetDetail",parameters);
    }

    public async Task<object> spotPrivatePostSupplementCustomerTradeFee (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementCustomerTradeFee",parameters);
    }

    public async Task<object> spotPrivatePostSupplementApiRestrictions (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementApiRestrictions",parameters);
    }

    public async Task<object> spotPrivatePostSupplementSystemPing (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementSystemPing",parameters);
    }

    public async Task<object> spotPrivatePostSupplementCreateOrderTest (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementCreateOrderTest",parameters);
    }

    public async Task<object> spotPrivatePostSupplementCreateOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementCreateOrder",parameters);
    }

    public async Task<object> spotPrivatePostSupplementCancelOrder (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementCancelOrder",parameters);
    }

    public async Task<object> spotPrivatePostSupplementCancelOrderBySymbol (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementCancelOrderBySymbol",parameters);
    }

    public async Task<object> spotPrivatePostSupplementOrdersInfo (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementOrdersInfo",parameters);
    }

    public async Task<object> spotPrivatePostSupplementOrdersInfoNoDeal (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementOrdersInfoNoDeal",parameters);
    }

    public async Task<object> spotPrivatePostSupplementOrdersInfoHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementOrdersInfoHistory",parameters);
    }

    public async Task<object> spotPrivatePostSupplementUserInfoAccount (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementUserInfoAccount",parameters);
    }

    public async Task<object> spotPrivatePostSupplementTransactionHistory (object parameters = null)
    {
        return await this.callAsync ("spotPrivatePostSupplementTransactionHistory",parameters);
    }

    public async Task<object> contractPublicGetCfdOpenApiV1PubGetTime (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetCfdOpenApiV1PubGetTime",parameters);
    }

    public async Task<object> contractPublicGetCfdOpenApiV1PubInstrument (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetCfdOpenApiV1PubInstrument",parameters);
    }

    public async Task<object> contractPublicGetCfdOpenApiV1PubMarketData (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetCfdOpenApiV1PubMarketData",parameters);
    }

    public async Task<object> contractPublicGetCfdOpenApiV1PubMarketOrder (object parameters = null)
    {
        return await this.callAsync ("contractPublicGetCfdOpenApiV1PubMarketOrder",parameters);
    }

}