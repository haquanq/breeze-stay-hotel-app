package com.haquanq.breezestay.shared.exception;

import com.haquanq.breezestay.shared.response.ApiResponse;
import java.util.HashMap;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.MethodArgumentNotValidException;
import org.springframework.web.bind.annotation.ControllerAdvice;
import org.springframework.web.bind.annotation.ExceptionHandler;
import org.springframework.web.context.request.WebRequest;

@ControllerAdvice
public class GlobalExceptionHandler {

    @ExceptionHandler(ResourceNotFoundException.class)
    public ResponseEntity<ApiResponse<?>> handleResourceNotFoundException(
        ResourceNotFoundException ex,
        WebRequest request
    ) {
        var body = ApiResponse.failure(HttpStatus.NOT_FOUND.name(), "Resource not found", null);
        return ResponseEntity.status(HttpStatus.NOT_FOUND).body(body);
    }

    @ExceptionHandler(Exception.class)
    public ResponseEntity<ApiResponse<?>> globalExceptionHandler(Exception ex, WebRequest request) {
        var body = ApiResponse.failure(HttpStatus.INTERNAL_SERVER_ERROR.name(), "Something wrong happened", null);
        return ResponseEntity.status(HttpStatus.INTERNAL_SERVER_ERROR).body(body);
    }

    @ExceptionHandler(MethodArgumentNotValidException.class)
    public ResponseEntity<ApiResponse<?>> handleValidationExceptions(MethodArgumentNotValidException ex) {
        var details = new HashMap<String, String>();

        ex
            .getBindingResult()
            .getFieldErrors()
            .forEach(error -> {
                details.put(error.getField(), error.getDefaultMessage());
            });

        var body = ApiResponse.failure(HttpStatus.BAD_REQUEST.name(), "Validation failed", details);
        return ResponseEntity.status(HttpStatus.BAD_REQUEST).body(body);
    }
}
