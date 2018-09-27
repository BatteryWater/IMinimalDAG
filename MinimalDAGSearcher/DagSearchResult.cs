﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalDAGSearcher
{
    public class DAGSearchResult<T>
    {
        /// <summary>
        /// The sequence recovered.
        /// </summary>
        public IEnumerable<T> MatchingSequence { get; private set; }

        /// <summary>
        /// The position(s) of any wild cards in the recovered sequence.
        /// </summary>
        public List<int> WildCardPositions { get; private set; }

        /// <summary>
        /// The starting index of the recovered sequence, relative to the <see cref="MinimalDAGSearcher"/> search space.
        /// </summary>
        public int SequenceStartIndex { get; private set; }
        
        public DAGSearchResult(IEnumerable<T> matchingSequence, List<int> wildCardPositions, int startIndex)
        {
            MatchingSequence = matchingSequence;
            WildCardPositions = wildCardPositions;
            SequenceStartIndex = startIndex;
        }
    }
}
