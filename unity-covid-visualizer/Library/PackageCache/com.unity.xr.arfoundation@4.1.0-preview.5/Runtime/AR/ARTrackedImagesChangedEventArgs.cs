﻿using System;
using System.Collections.Generic;

namespace UnityEngine.XR.ARFoundation
{
    /// <summary>
    /// Event arguments for the <see cref="ARTrackedImageManager.trackedImagesChanged"/> event.
    /// </summary>
    public struct ARTrackedImagesChangedEventArgs : IEquatable<ARTrackedImagesChangedEventArgs>
    {
        /// <summary>
        /// The list of <see cref="ARTrackedImage"/>s added since the last event.
        /// </summary>
        public List<ARTrackedImage> added { get; private set; }

        /// <summary>
        /// The list of <see cref="ARTrackedImage"/>s udpated since the last event.
        /// </summary>
        public List<ARTrackedImage> updated { get; private set; }

        /// <summary>
        /// The list of <see cref="ARTrackedImage"/>s removed since the last event.
        /// </summary>
        public List<ARTrackedImage> removed { get; private set; }

        /// <summary>
        /// Constructs an <see cref="ARTrackedImagesChangedEventArgs"/>.
        /// </summary>
        /// <param name="added">The list of <see cref="ARTrackedImage"/>s added since the last event.</param>
        /// <param name="updated">The list of <see cref="ARTrackedImage"/>s updated since the last event.</param>
        /// <param name="removed">The list of <see cref="ARTrackedImage"/>s removed since the last event.</param>
        public ARTrackedImagesChangedEventArgs(
            List<ARTrackedImage> added,
            List<ARTrackedImage> updated,
            List<ARTrackedImage> removed)
        {
            this.added = added;
            this.updated = updated;
            this.removed = removed;
        }

        /// <summary>
        /// Generates a hash suitable for use with containers like `HashSet` and `Dictionary`.
        /// </summary>
        /// <returns>A hash code generated from this object's fields.</returns>
        public override int GetHashCode() => HashCode.Combine(
            HashCode.ReferenceHash(added),
            HashCode.ReferenceHash(updated),
            HashCode.ReferenceHash(removed));

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="obj">The `object` to compare against.</param>
        /// <returns>`True` if <paramref name="obj"/> is of type <see cref="ARTrackedImagesChangedEventArgs"/> and
        /// <see cref="Equals(ARTrackedImagesChangedEventArgs)"/> also returns `true`; otherwise `false`.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is ARTrackedImagesChangedEventArgs))
                return false;

            return Equals((ARTrackedImagesChangedEventArgs)obj);
        }

        /// <summary>
        /// Generates a string representation of this <see cref="ARTrackedImagesChangedEventArgs"/>.
        /// </summary>
        /// <returns>A string representation of this <see cref="ARTrackedImagesChangedEventArgs"/>.</returns>
        public override string ToString()
        {
            return string.Format("Added: {0}, Updated: {1}, Removed: {2}",
                added == null ? 0 : added.Count,
                updated == null ? 0 : updated.Count,
                removed == null ? 0 : removed.Count);
        }

        /// <summary>
        /// Tests for equality.
        /// </summary>
        /// <param name="other">The other <see cref="ARTrackedImagesChangedEventArgs"/> to compare against.</param>
        /// <returns>`True` if every field in <paramref name="other"/> is equal to this <see cref="ARTrackedImagesChangedEventArgs"/>, otherwise false.</returns>
        public bool Equals(ARTrackedImagesChangedEventArgs other)
        {
            return
                (added == other.added) &&
                (updated == other.updated) &&
                (removed == other.removed);
        }

        /// <summary>
        /// Tests for equality. Same as <see cref="Equals(ARTrackedImagesChangedEventArgs)"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the comparison.</param>
        /// <param name="rhs">The right-hand side of the comparison.</param>
        /// <returns>`True` if <paramref name="lhs"/> is equal to <paramref name="rhs"/>, otherwise `false`.</returns>
        public static bool operator ==(ARTrackedImagesChangedEventArgs lhs, ARTrackedImagesChangedEventArgs rhs)
        {
            return lhs.Equals(rhs);
        }

        /// <summary>
        /// Tests for inequality. Same as `!`<see cref="Equals(ARTrackedImagesChangedEventArgs)"/>.
        /// </summary>
        /// <param name="lhs">The left-hand side of the comparison.</param>
        /// <param name="rhs">The right-hand side of the comparison.</param>
        /// <returns>`True` if <paramref name="lhs"/> is not equal to <paramref name="rhs"/>, otherwise `false`.</returns>
        public static bool operator !=(ARTrackedImagesChangedEventArgs lhs, ARTrackedImagesChangedEventArgs rhs)
        {
            return !lhs.Equals(rhs);
        }
    }
}