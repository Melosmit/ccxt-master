import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

from ccxt.test.exchange.base import test_trading_fee  # noqa E402
from ccxt.test.exchange.base import test_shared_methods  # noqa E402

async def test_fetch_trading_fees(exchange, skipped_properties):
    method = 'fetchTradingFees'
    fees = await exchange.fetch_trading_fees()
    symbols = list(fees.keys())
    test_shared_methods.assert_non_emtpy_array(exchange, skipped_properties, method, symbols)
    for i in range(0, len(symbols)):
        symbol = symbols[i]
        test_trading_fee(exchange, skipped_properties, method, symbol, fees[symbol])