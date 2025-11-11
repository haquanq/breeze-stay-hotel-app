package com.haquanq.breezestay.shared.response;

import java.time.Instant;
import java.util.UUID;

public class ApiResponse<T extends Object> {

    public boolean success;
    public Object error;
    public T data;
    public final String requestId = UUID.randomUUID().toString();
    public final Instant timestamp = Instant.now();

    public static <T> ApiResponse<T> success(T data) {
        ApiResponse<T> response = new ApiResponse<>();
        response.success = true;
        response.data = data;
        return response;
    }

    public static <T> ApiResponse<T> failure(String code, String message, Object details) {
        ApiResponse<T> response = new ApiResponse<>();
        response.success = false;
        response.error = new ApiError(code, message, details);
        return response;
    }
}
