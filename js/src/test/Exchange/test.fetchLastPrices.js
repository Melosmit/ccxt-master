// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

import assert from 'assert';
import testLastPrice from './base/test.lastPrice.js';
import testSharedMethods from './base/test.sharedMethods.js';
async function testFetchLastPrices(exchange, skippedProperties, symbol) {
    const method = 'fetchLastprices';
    // log ('fetching all tickers at once...')
    let response = undefined;
    let checkedSymbol = undefined;
    try {
        response = await exchange.fetchLastPrices();
    }
    catch (e) {
        response = await exchange.fetchLastPrices([symbol]);
        checkedSymbol = symbol;
    }
    assert(typeof response === 'object', exchange.id + ' ' + method + ' ' + checkedSymbol + ' must return an object. ' + exchange.json(response));
    const values = Object.values(response);
    testSharedMethods.assertNonEmtpyArray(exchange, skippedProperties, method, values, checkedSymbol);
    for (let i = 0; i < values.length; i++) {
        // todo: symbol check here
        testLastPrice(exchange, skippedProperties, method, values[i], checkedSymbol);
    }
}
export default testFetchLastPrices;