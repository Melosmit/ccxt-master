// ----------------------------------------------------------------------------

// PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
// https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code
// EDIT THE CORRESPONDENT .ts FILE INSTEAD

import testBorrowInterest from './base/test.borrowInterest.js';
import testSharedMethods from './base/test.sharedMethods.js';
async function testFetchBorrowInterest(exchange, skippedProperties, code, symbol) {
    const method = 'fetchBorrowInterest';
    const borrowInterest = await exchange.fetchBorrowInterest(code, symbol);
    testSharedMethods.assertNonEmtpyArray(exchange, skippedProperties, method, borrowInterest, code);
    for (let i = 0; i < borrowInterest.length; i++) {
        testBorrowInterest(exchange, skippedProperties, method, borrowInterest[i], code, symbol);
    }
}
export default testFetchBorrowInterest;