# Elasticsearch Query DSL Generator

In this simple project, you can create Elasticsearch Query from a file that contains data of a specific field.

For example;

if a file contains this data

20326887
33483362
36919973
44805907
35467070

Output will be;

{
  "query": {
    "bool": {
      "should": [
        {
          "match_phrase": {
            "Id": "20326887"
          }
        },
        {
          "match_phrase": {
            "Id": "33483362"
          }
        },
        {
          "match_phrase": {
            "Id": "36919973"
          }
        },
        {
          "match_phrase": {
            "Id": "44805907"
          }
        },
        {
          "match_phrase": {
            "Id": "35467070"
          }
        }
      ],
      "minimum_should_match": 1
    }
  }
}
