import os
import sys

root = os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.dirname(os.path.abspath(__file__))))))
sys.path.append(root)

# ----------------------------------------------------------------------------

# PLEASE DO NOT EDIT THIS FILE, IT IS GENERATED AND WILL BE OVERWRITTEN:
# https://github.com/ccxt/ccxt/blob/master/CONTRIBUTING.md#how-to-contribute-code

# ----------------------------------------------------------------------------
# -*- coding: utf-8 -*-

from ccxt.base.errors import InvalidNonce  # noqa E402
from ccxt.test.exchange.base import test_order_book  # noqa E402
from ccxt.test.exchange.base import test_shared_methods  # noqa E402

async def test_watch_order_book_for_symbols(exchange, skipped_properties, symbols):
    method = 'watchOrderBookForSymbols'
    now = exchange.milliseconds()
    ends = now + 15000
    while now < ends:
        response = None
        try:
            response = await exchange.watch_order_book_for_symbols(symbols)
        except Exception as e:
            # temporary fix for InvalidNonce for c#
            if not test_shared_methods.is_temporary_failure(e) and not (isinstance(e, InvalidNonce)):
                raise e
            now = exchange.milliseconds()
            continue
        # [ response, skippedProperties ] = fixPhpObjectArray (exchange, response, skippedProperties);
        assert isinstance(response, dict), exchange.id + ' ' + method + ' ' + exchange.json(symbols) + ' must return an object. ' + exchange.json(response)
        now = exchange.milliseconds()
        test_shared_methods.assert_in_array(exchange, skipped_properties, method, response, 'symbol', symbols)
        test_order_book(exchange, skipped_properties, method, response, None)