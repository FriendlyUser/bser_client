#!/usr/bin/env bash
#-------------------------------------------------------------------------------------------------------------
# Copyright (c) David Li. All rights reserved.
# Licensed under the MIT License.
#-------------------------------------------------------------------------------------------------------------

# Syntax: ./azcli-debian.sh
set -e

if [ "$(id -u)" -ne 0 ]; then
    echo -e 'Script must be run a root. Use sudo, su, or add "USER root" to your Dockerfile before running this script.'
    exit 1
fi

apt-get install doxygen -y