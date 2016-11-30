/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

#include "CSSInterop.h"

static CSSInteropLoggerFunc gManagedFunc;

static int unmanagedLogger(CSSLogLevel level, const char *format, va_list args) {
  int result = 0;
  if (gManagedFunc) {
    char buffer[256];
    result = vsnprintf(buffer, sizeof(buffer), format, args);
    (*gManagedFunc)(level, buffer);
  }
  return result;
}

void CSSInteropSetLogger(CSSInteropLoggerFunc managedFunc) {
  gManagedFunc = managedFunc;
  CSSLayoutSetLogger(&unmanagedLogger);
}
