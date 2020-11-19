#!/bin/bash

cd -- "$(dirname "$BASH_SOURCE")"
git add .
git commit -m "Making backup commit before running update"
git pull -Xtheirs --no-edit
