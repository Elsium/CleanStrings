# Formating string instruction


---
## Create config

```c#
textFormat <string_for_format> = new textFormat(<bool_for_eng>, <bool_for_rus>, <bool_for_dig>, <string_whiteList>);
```
- `<string_method>` - **name of method**
- `<bool_for_eng>` - **will be include eng abc**, *take bool (true/false)*
- `<bool_for_rus>` - **will be include rus abc**, *take bool (true/false)*
- `<bool_for_dig>` - **will be include digits**, *take bool (true/false)*
- `<string_whiteList>` - **white list of symbols**, *take string (ex: "</>")*

---
## Work with method

```c#
string <result_name>;
<result_name> = <string_for_format>.format(<string_which_you_need_to_format>)
```
- `<result_name>` - **string which take result after formating**
- `<string__format>` - **string which will be formating**