error_hierarchy = {
    'BaseError': {
        'ExchangeError': {
            'AuthenticationError': {
                'PermissionDenied': {
                    'AccountNotEnabled': {},
                },
                'AccountSuspended': {},
            },
            'ArgumentsRequired': {},
            'BadRequest': {
                'BadSymbol': {},
            },
            'OperationRejected': {
                'NoChange': {
                    'MarginModeAlreadySet': {},
                },
                'MarketClosed': {},
                'ManualInteractionNeeded': {},
            },
            'InsufficientFunds': {},
            'InvalidAddress': {
                'AddressPending': {},
            },
            'InvalidOrder': {
                'OrderNotFound': {},
                'OrderNotCached': {},
                'OrderImmediatelyFillable': {},
                'OrderNotFillable': {},
                'DuplicateOrderId': {},
                'ContractUnavailable': {},
            },
            'NotSupported': {},
            'InvalidProxySettings': {},
            'ExchangeClosedByUser': {},
        },
        'OperationFailed': {
            'NetworkError': {
                'DDoSProtection': {},
                'RateLimitExceeded': {},
                'ExchangeNotAvailable': {
                    'OnMaintenance': {},
                },
                'InvalidNonce': {
                    'ChecksumError': {},
                },
                'RequestTimeout': {},
            },
            'BadResponse': {
                'NullResponse': {},
            },
            'CancelPending': {},
        },
        'UnsubscribeError': {},
    },
}


class BaseError(Exception):
    pass


class ExchangeError(BaseError):
    pass


class AuthenticationError(ExchangeError):
    pass


class PermissionDenied(AuthenticationError):
    pass


class AccountNotEnabled(PermissionDenied):
    pass


class AccountSuspended(AuthenticationError):
    pass


class ArgumentsRequired(ExchangeError):
    pass


class BadRequest(ExchangeError):
    pass


class BadSymbol(BadRequest):
    pass


class OperationRejected(ExchangeError):
    pass


class NoChange(OperationRejected):
    pass


class MarginModeAlreadySet(NoChange):
    pass


class MarketClosed(OperationRejected):
    pass


class ManualInteractionNeeded(OperationRejected):
    pass


class InsufficientFunds(ExchangeError):
    pass


class InvalidAddress(ExchangeError):
    pass


class AddressPending(InvalidAddress):
    pass


class InvalidOrder(ExchangeError):
    pass


class OrderNotFound(InvalidOrder):
    pass


class OrderNotCached(InvalidOrder):
    pass


class OrderImmediatelyFillable(InvalidOrder):
    pass


class OrderNotFillable(InvalidOrder):
    pass


class DuplicateOrderId(InvalidOrder):
    pass


class ContractUnavailable(InvalidOrder):
    pass


class NotSupported(ExchangeError):
    pass


class InvalidProxySettings(ExchangeError):
    pass


class ExchangeClosedByUser(ExchangeError):
    pass


class OperationFailed(BaseError):
    pass


class NetworkError(OperationFailed):
    pass


class DDoSProtection(NetworkError):
    pass


class RateLimitExceeded(NetworkError):
    pass


class ExchangeNotAvailable(NetworkError):
    pass


class OnMaintenance(ExchangeNotAvailable):
    pass


class InvalidNonce(NetworkError):
    pass


class ChecksumError(InvalidNonce):
    pass


class RequestTimeout(NetworkError):
    pass


class BadResponse(OperationFailed):
    pass


class NullResponse(BadResponse):
    pass


class CancelPending(OperationFailed):
    pass


class UnsubscribeError(BaseError):
    pass


__all__ = [
    'error_hierarchy',
    'BaseError',
    'ExchangeError',
    'AuthenticationError',
    'PermissionDenied',
    'AccountNotEnabled',
    'AccountSuspended',
    'ArgumentsRequired',
    'BadRequest',
    'BadSymbol',
    'OperationRejected',
    'NoChange',
    'MarginModeAlreadySet',
    'MarketClosed',
    'ManualInteractionNeeded',
    'InsufficientFunds',
    'InvalidAddress',
    'AddressPending',
    'InvalidOrder',
    'OrderNotFound',
    'OrderNotCached',
    'OrderImmediatelyFillable',
    'OrderNotFillable',
    'DuplicateOrderId',
    'ContractUnavailable',
    'NotSupported',
    'InvalidProxySettings',
    'ExchangeClosedByUser',
    'OperationFailed',
    'NetworkError',
    'DDoSProtection',
    'RateLimitExceeded',
    'ExchangeNotAvailable',
    'OnMaintenance',
    'InvalidNonce',
    'ChecksumError',
    'RequestTimeout',
    'BadResponse',
    'NullResponse',
    'CancelPending',
    'UnsubscribeError'
]