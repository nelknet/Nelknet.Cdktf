#!/usr/bin/env bash

set -euo pipefail

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
REPO_ROOT="$(cd "${SCRIPT_DIR}/.." && pwd)"

cd "${REPO_ROOT}"

if [ -f "package-lock.json" ]; then
  npm ci
else
  npm install
fi

dotnet build -p:ForceCodeGen=true

echo "Generation complete. Run 'git status' to review changes before committing."
