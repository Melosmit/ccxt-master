// -------------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

// -------------------------------------------------------------------------------

namespace ccxt;

public partial class coincatch : Exchange
{
    public coincatch (object args = null): base(args) {}

    public async Task<object> publicGetApiSpotV1PublicTime (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1PublicTime",parameters);
    }

    public async Task<object> publicGetApiSpotV1PublicCurrencies (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1PublicCurrencies",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketTicker",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketTickers (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketTickers",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketFills (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketFills",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketFillsHistory (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketFillsHistory",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketCandles (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketCandles",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketHistoryCandles (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketHistoryCandles",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketDepth",parameters);
    }

    public async Task<object> publicGetApiSpotV1MarketMergeDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetApiSpotV1MarketMergeDepth",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketContracts (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketContracts",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketMergeDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketMergeDepth",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketDepth (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketDepth",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketTicker (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketTicker",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketTickers (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketTickers",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketFills (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketFills",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketFillsHistory (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketFillsHistory",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketCandles (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketCandles",parameters);
    }

    public async Task<object> publicGetPiMixV1MarketIndex (object parameters = null)
    {
        return await this.callAsync ("publicGetPiMixV1MarketIndex",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketFundingTime (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketFundingTime",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketHistoryFundRate (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketHistoryFundRate",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketCurrentFundRate (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketCurrentFundRate",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketOpenInterest (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketOpenInterest",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketMarkPrice (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketMarkPrice",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketSymbolLeverage (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketSymbolLeverage",parameters);
    }

    public async Task<object> publicGetApiMixV1MarketQueryPositionLever (object parameters = null)
    {
        return await this.callAsync ("publicGetApiMixV1MarketQueryPositionLever",parameters);
    }

    public async Task<object> privateGetApiSpotV1WalletDepositAddress (object parameters = null)
    {
        return await this.callAsync ("privateGetApiSpotV1WalletDepositAddress",parameters);
    }

    public async Task<object> privateGetPiSpotV1WalletWithdrawalList (object parameters = null)
    {
        return await this.callAsync ("privateGetPiSpotV1WalletWithdrawalList",parameters);
    }

    public async Task<object> privateGetApiSpotV1WalletWithdrawalListV2 (object parameters = null)
    {
        return await this.callAsync ("privateGetApiSpotV1WalletWithdrawalListV2",parameters);
    }

    public async Task<object> privateGetApiSpotV1WalletDepositList (object parameters = null)
    {
        return await this.callAsync ("privateGetApiSpotV1WalletDepositList",parameters);
    }

    public async Task<object> privateGetApiSpotV1AccountGetInfo (object parameters = null)
    {
        return await this.callAsync ("privateGetApiSpotV1AccountGetInfo",parameters);
    }

    public async Task<object> privateGetApiSpotV1AccountAssets (object parameters = null)
    {
        return await this.callAsync ("privateGetApiSpotV1AccountAssets",parameters);
    }

    public async Task<object> privateGetApiSpotV1AccountTransferRecords (object parameters = null)
    {
        return await this.callAsync ("privateGetApiSpotV1AccountTransferRecords",parameters);
    }

    public async Task<object> privateGetApiMixV1AccountAccount (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1AccountAccount",parameters);
    }

    public async Task<object> privateGetApiMixV1AccountAccounts (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1AccountAccounts",parameters);
    }

    public async Task<object> privateGetApiMixV1PositionSinglePositionV2 (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1PositionSinglePositionV2",parameters);
    }

    public async Task<object> privateGetApiMixV1PositionAllPositionV2 (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1PositionAllPositionV2",parameters);
    }

    public async Task<object> privateGetApiMixV1AccountAccountBill (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1AccountAccountBill",parameters);
    }

    public async Task<object> privateGetApiMixV1AccountAccountBusinessBill (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1AccountAccountBusinessBill",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderCurrent (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderCurrent",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderMarginCoinCurrent (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderMarginCoinCurrent",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderHistory (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderHistory",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderHistoryProductType (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderHistoryProductType",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderDetail (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderDetail",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderFills (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderFills",parameters);
    }

    public async Task<object> privateGetApiMixV1OrderAllFills (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1OrderAllFills",parameters);
    }

    public async Task<object> privateGetApiMixV1PlanCurrentPlan (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1PlanCurrentPlan",parameters);
    }

    public async Task<object> privateGetApiMixV1PlanHistoryPlan (object parameters = null)
    {
        return await this.callAsync ("privateGetApiMixV1PlanHistoryPlan",parameters);
    }

    public async Task<object> privatePostApiSpotV1WalletTransferV2 (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1WalletTransferV2",parameters);
    }

    public async Task<object> privatePostApiSpotV1WalletWithdrawalV2 (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1WalletWithdrawalV2",parameters);
    }

    public async Task<object> privatePostApiSpotV1WalletWithdrawalInnerV2 (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1WalletWithdrawalInnerV2",parameters);
    }

    public async Task<object> privatePostApiSpotV1AccountBills (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1AccountBills",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeOrders",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeBatchOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeBatchOrders",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeCancelOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeCancelOrder",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeCancelOrderV2 (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeCancelOrderV2",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeCancelSymbolOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeCancelSymbolOrder",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeCancelBatchOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeCancelBatchOrders",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeCancelBatchOrdersV2 (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeCancelBatchOrdersV2",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeOrderInfo (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeOrderInfo",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeOpenOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeOpenOrders",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeHistory (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeHistory",parameters);
    }

    public async Task<object> privatePostApiSpotV1TradeFills (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1TradeFills",parameters);
    }

    public async Task<object> privatePostApiSpotV1PlanPlacePlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1PlanPlacePlan",parameters);
    }

    public async Task<object> privatePostApiSpotV1PlanModifyPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1PlanModifyPlan",parameters);
    }

    public async Task<object> privatePostApiSpotV1PlanCancelPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1PlanCancelPlan",parameters);
    }

    public async Task<object> privatePostApiSpotV1PlanCurrentPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1PlanCurrentPlan",parameters);
    }

    public async Task<object> privatePostApiSpotV1PlanHistoryPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1PlanHistoryPlan",parameters);
    }

    public async Task<object> privatePostApiSpotV1PlanBatchCancelPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiSpotV1PlanBatchCancelPlan",parameters);
    }

    public async Task<object> privatePostApiMixV1AccountOpenCount (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1AccountOpenCount",parameters);
    }

    public async Task<object> privatePostApiMixV1AccountSetLeverage (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1AccountSetLeverage",parameters);
    }

    public async Task<object> privatePostApiMixV1AccountSetMargin (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1AccountSetMargin",parameters);
    }

    public async Task<object> privatePostApiMixV1AccountSetMarginMode (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1AccountSetMarginMode",parameters);
    }

    public async Task<object> privatePostApiMixV1AccountSetPositionMode (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1AccountSetPositionMode",parameters);
    }

    public async Task<object> privatePostApiMixV1OrderPlaceOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1OrderPlaceOrder",parameters);
    }

    public async Task<object> privatePostApiMixV1OrderBatchOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1OrderBatchOrders",parameters);
    }

    public async Task<object> privatePostApiMixV1OrderCancelOrder (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1OrderCancelOrder",parameters);
    }

    public async Task<object> privatePostApiMixV1OrderCancelBatchOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1OrderCancelBatchOrders",parameters);
    }

    public async Task<object> privatePostApiMixV1OrderCancelSymbolOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1OrderCancelSymbolOrders",parameters);
    }

    public async Task<object> privatePostApiMixV1OrderCancelAllOrders (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1OrderCancelAllOrders",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanPlacePlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanPlacePlan",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanModifyPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanModifyPlan",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanModifyPlanPreset (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanModifyPlanPreset",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanPlaceTPSL (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanPlaceTPSL",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanPlaceTrailStop (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanPlaceTrailStop",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanPlacePositionsTPSL (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanPlacePositionsTPSL",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanModifyTPSLPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanModifyTPSLPlan",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanCancelPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanCancelPlan",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanCancelSymbolPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanCancelSymbolPlan",parameters);
    }

    public async Task<object> privatePostApiMixV1PlanCancelAllPlan (object parameters = null)
    {
        return await this.callAsync ("privatePostApiMixV1PlanCancelAllPlan",parameters);
    }

}