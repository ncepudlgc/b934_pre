#!/bin/bash
NAMESPACE="${1:-codebase_b934_app}"
docker build -t "$NAMESPACE" .