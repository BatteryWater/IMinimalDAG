# IMinimalDAG 

An incrementally constructed (ie no trie involved) minimal directed acyclic graph. Aimed at minimum-node storage of collections of collections of values for fast, memory-friendly searching. Supports both ref and value types. Happily serializes down to a gzipped json (and back) for persistence of calculated MinimalDAGs (note this is not a significant speed increase until collections are very* large). *hundreds of thousands of entries.
