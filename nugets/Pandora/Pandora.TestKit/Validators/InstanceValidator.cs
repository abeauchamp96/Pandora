// Copyright (c) Alexandre Beauchamp. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;

namespace Pandora.TestKit.Validators
{
    public sealed class InstanceValidator<T>
    {
        private readonly IList<Func<T, bool>> validations = new List<Func<T, bool>>();

        private InstanceValidator()
        {
        }

        public static InstanceValidator<T> Build() => new();

        public InstanceValidator<T> WithValidation(Action<T> validation)
        {
            return this.WithValidation(v =>
            {
                validation(v);
                return true;
            });
        }

        public InstanceValidator<T> WithValidation(Func<T, bool> validation)
        {
            this.validations.Add(validation);
            return this;
        }

        public bool IsValid(T value)
        {
            foreach (var validation in this.validations)
            {
                if (!validation(value))
                    return false;
            }

            return true;
        }
    }
}
