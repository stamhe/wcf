// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.ObjectModel;

namespace System.ServiceModel.Description
{
    public class OperationDescriptionCollection : Collection<OperationDescription>
    {
        internal OperationDescriptionCollection()
        {
        }

        public OperationDescription Find(string name)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Name == name)
                    return this[i];
            }
            return null;
        }

        public Collection<OperationDescription> FindAll(string name)
        {
            Collection<OperationDescription> results = new Collection<OperationDescription>();
            for (int i = 0; i < this.Count; i++)
            {
                if (this[i].Name == name)
                    results.Add(this[i]);
            }
            return results;
        }

        protected override void InsertItem(int index, OperationDescription item)
        {
            if (item == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("item");
            }
            base.InsertItem(index, item);
        }

        protected override void SetItem(int index, OperationDescription item)
        {
            if (item == null)
            {
                throw DiagnosticUtility.ExceptionUtility.ThrowHelperArgumentNull("item");
            }
            base.SetItem(index, item);
        }
    }
}

