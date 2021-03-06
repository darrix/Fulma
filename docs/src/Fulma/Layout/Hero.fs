module Layouts.Hero

open Fable.Helpers.React
open Fulma
open Fulma.BulmaClasses

let iconInteractive () =
    Hero.hero [ ]
        [ Hero.body [ ]
            [ Container.container [ Container.IsFluid ]
                [ Heading.h1 [ ]
                    [ str "Header" ]
                  Heading.h2 [ Heading.IsSubtitle ]
                    [ str "Subtitle" ] ] ] ]

let centered () =
    Hero.hero [ Hero.Color IsSuccess
                Hero.IsMedium ]
        [ Hero.head [ ]
            [ Tabs.tabs [ Tabs.IsBoxed
                          Tabs.IsCentered ]
                [ Tabs.tab [ Tabs.Tab.IsActive true ]
                    [ a [ ] [ str "Fable" ] ]
                  Tabs.tab [ ]
                    [ a [ ] [ str "Elmish" ] ]
                  Tabs.tab [ ]
                    [ a [ ] [ str "Bulma" ] ]
                  Tabs.tab [ ]
                    [ a [ ] [ str "Hink" ] ] ] ]
          Hero.body [ ]
            [ Container.container [ Container.IsFluid
                                    Container.CustomClass Bulma.Properties.Alignment.HasTextCentered ]
                [ Heading.h1 [ ]
                    [ str "Header" ]
                  Heading.h2 [ Heading.IsSubtitle ]
                    [ str "Subtitle" ] ] ] ]

let view =
    Render.docPage [ Render.contentFromMarkdown
                        """
# Hero

*[Bulma documentation](http://bulma.io/documentation/layout/hero/)*
                        """
                     Render.docSection
                        ""
                        (Widgets.Showcase.view iconInteractive (Render.getViewSource iconInteractive))
                     Render.docSection
                        ""
                        (Widgets.Showcase.view centered (Render.getViewSource centered))
                     Render.contentFromMarkdown
                        """
### Properties

Colors:

- `Hero.Color IsBlack`
- `Hero.Color IsDark`
- `Hero.Color IsLight`
- `Hero.Color IsWhite`
- `Hero.Color IsPrimary`
- `Hero.Color IsInfo`
- `Hero.Color IsSuccess`
- `Hero.Color IsWarning`
- `Hero.Color IsDanger`

Sizes:

- `Hero.Size IsMedium`
- `Hero.Size IsLarge`
- `Hero.Size IsHalfHeight`
- `Hero.Size IsFullHeight`

Styles:

- `Hero.IsBold`
                        """
                        ]
