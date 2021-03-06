﻿using GitHub.Primitives;
using GitHub.UI;
using System.ComponentModel;

namespace GitHub.Models
{
    public interface ISimpleRepositoryModel : INotifyPropertyChanged
    {
        string Name { get; }
        UriString CloneUrl { get; }
        string LocalPath { get; }
        Octicon Icon { get; }
        string Owner { get; }
        IBranch CurrentBranch { get; }

        void SetIcon(bool isPrivate, bool isFork);


        /// <summary>
        /// Updates the url information based on the local path
        /// </summary>
        void Refresh();
        UriString GenerateUrl(string path = null, int startLine = -1, int endLine = -1);
    }
}
