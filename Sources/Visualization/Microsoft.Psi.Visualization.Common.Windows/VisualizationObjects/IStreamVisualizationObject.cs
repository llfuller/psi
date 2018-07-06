﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

namespace Microsoft.Psi.Visualization.VisualizationObjects
{
    using System.Collections.Generic;
    using Microsoft.Psi.Visualization.Datasets;

    /// <summary>
    /// Represents a stream visualization object.
    /// </summary>
    public interface IStreamVisualizationObject
    {
        /// <summary>
        /// Closes the underlying stream.
        /// </summary>
        void CloseStream();

        /// <summary>
        /// Update the store bindings for given enumeration of partitions.
        /// </summary>
        /// <param name="partitions">The partitions to update the bindings with.</param>
        void UpdateStoreBindings(IEnumerable<PartitionViewModel> partitions);
    }
}
