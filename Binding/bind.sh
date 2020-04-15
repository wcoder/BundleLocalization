#!/bin/bash

sharpie bind \
--output=BundleLocalization \
--namespace=BundleLocalization \
--sdk=iphoneos13.4 \
-scope ../Native/BundleLocalization/Classes/ \
../Native/BundleLocalization/Classes/*.h