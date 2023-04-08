# Instructions

## Checkbox
1. Create a __Canvas__, change its color if you need.
2. Add a __Toggle__ (UI -> Toggle). Change font size, checkmark size if needed.
3. In Toggle in _OnValueChanged_ component add new item, drop a Title, select GameObject -> SetActive.

## Radio Button
1. Create a __Canvas__, change its color if you need.
2. (not necessary) Add a __Panel__, change its size and color.
3. Add some __Text__ (may be Question).
4. Create __Empty GameObject__ (rename it to _Options_) for all answers.
5. Inside the Options create a __Toggle__ (UI -> Toggle), rename it, change Label Text, font size, position, etc.
6. Dublicate first option as many times as you need. Change info.
7. Add a __Toggle Group__ component to Options.
8. Select ALL toggles, in __Toggle__ component change _Group_ to "Options".
9. Inside the Panel create a __Button__ (rename to Submit Button).
10. Create a new __Script__. Add it to Options.
11. Create a Submit method. Inside a OnClick() component of SubmitButton add Options and check its Submit method.
12. You can also create a new __Sprite__ (2d objects -> sprites -> circle), and set it as a source image in toggle's background.