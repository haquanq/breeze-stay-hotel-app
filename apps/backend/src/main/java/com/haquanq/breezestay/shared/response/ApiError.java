package com.haquanq.breezestay.shared.response;

public record ApiError(String code, String message, Object details) {}
