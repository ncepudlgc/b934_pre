FROM mcr.microsoft.com/dotnet/sdk:6.0-bullseye-slim

# Install required system packages
RUN apt-get update && apt-get install -y \
    git \
    wget \
    unzip \
    && rm -rf /var/lib/apt/lists/*

# Set working directory
WORKDIR /workspace

# Copy project files
COPY . /workspace/

# Default to interactive shell for development
CMD ["/bin/bash"]