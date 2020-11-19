#!/bin/bash

cd -- "$(dirname "$BASH_SOURCE")"
git add .
git commit -m "Making backup commit before running update" > /dev/null
git pull -Xtheirs --no-edit
