﻿// Copyright (c) Allan Hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace App.Metrics.Core.Options
{
    /// <summary>
    ///     Configuration of a Metric that will be measured
    /// </summary>
    public abstract class MetricValueOptions
    {
        protected MetricValueOptions()
        {
            Tags = new MetricTags();
            MeasurementUnit = Unit.None;
        }

        /// <summary>
        ///     Gets or sets the context for which the metric belongs e.g. Application.WebRequests
        /// </summary>
        /// <value>
        ///     The context.
        /// </value>
        public string Context { get; set; }

        /// <summary>
        ///     Gets or sets the description of what is being measured, a <see cref="Unit" /> is something that is expressed in MB,
        ///     kB for example
        /// </summary>
        /// <value>
        ///     The measurement unit.
        /// </value>
        public Unit MeasurementUnit { get; set; }

        /// <summary>
        ///     Gets or sets the name of the Metric being measure, this should be unique per <see cref="MetricType" />
        /// </summary>
        /// <value>
        ///     The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the <see cref="MetricTags" /> associated with the metric, this is useful for grouping metrics when
        ///     visualizing
        /// </summary>
        /// <value>
        ///     The tags.
        /// </value>
        public MetricTags Tags { get; set; }
    }
}