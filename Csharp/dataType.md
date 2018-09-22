# Date Type

| type     | size(bytes)     | .NET type       | range                                                   |
|----------|-----------------|-----------------|---------------------------------------------------------|
| int      | 4               | System.Int32    | -2,147,483,648 to 2,147,483,647                         |
| long     | 8               | System.Int64    | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 |
| float    | 4               | System.Single   | +/-3.4 x 10^38                                          |
| double   | 8               | System.Double   | +/-1.7 x 10^308                                         |
| decimal  | 16              | System.Decimal  | 28 significant figures                                  |
| char     | 2               | System.Char     |                                                         |
| bool     | 1               | System.Boolean  | True or False                                           |
| DateTime | 8               | System.DateTime | 0:00:00 on 01/01/0001 to 23:59:59 on 12/31/9999         |
| string   | 2 per character | System.String   |                                                         |