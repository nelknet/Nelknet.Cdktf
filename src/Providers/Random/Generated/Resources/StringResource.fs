namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StringResourceState<'Length> = { assignments: ResizeArray<random.StringResource.StringResourceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string">random_string</a>.
    /// </summary>
    type StringResourceBuilder(logicalId: string) =
        member _.Yield(_: unit) : StringResourceState<Missing> =
            ({ assignments = ResizeArray() } : StringResourceState<Missing>)

        member _.Zero(()) : StringResourceState<Missing> =
            ({ assignments = ResizeArray() } : StringResourceState<Missing>)

        /// <summary>
        /// The length of the string desired. The minimum value for length is 1 and, length must also be >= (`min_upper` + `min_lower` + `min_numeric` + `min_special`). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#length-1">StringResource#length</a>
        /// </summary>
        [<CustomOperation "length">]
        member _.Length(state: StringResourceState<Missing>, value: double) : StringResourceState<Present> =
            state.assignments.Add(fun config -> config.Length <- value)
            ({ assignments = state.assignments } : StringResourceState<Present>)

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#keepers-1">StringResource#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: StringResourceState<'Length>, value: seq<string * string>) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include lowercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#lower-1">StringResource#lower</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "lower">]
        member _.Lower(state: StringResourceState<'Length>, value: bool) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Lower <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include lowercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#lower-1">StringResource#lower</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "lower">]
        member _.Lower(state: StringResourceState<'Length>, value: HashiCorp.Cdktf.IResolvable) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Lower <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Minimum number of lowercase alphabet characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#min_lower-1">StringResource#min_lower</a>
        /// </summary>
        [<CustomOperation "min_lower">]
        member _.MinLower(state: StringResourceState<'Length>, value: double) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.MinLower <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Minimum number of numeric characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#min_numeric-1">StringResource#min_numeric</a>
        /// </summary>
        [<CustomOperation "min_numeric">]
        member _.MinNumeric(state: StringResourceState<'Length>, value: double) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.MinNumeric <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Minimum number of special characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#min_special-1">StringResource#min_special</a>
        /// </summary>
        [<CustomOperation "min_special">]
        member _.MinSpecial(state: StringResourceState<'Length>, value: double) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.MinSpecial <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Minimum number of uppercase alphabet characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#min_upper-1">StringResource#min_upper</a>
        /// </summary>
        [<CustomOperation "min_upper">]
        member _.MinUpper(state: StringResourceState<'Length>, value: double) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.MinUpper <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. **NOTE**: This is deprecated, use `numeric` instead. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#number-1">StringResource#number</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "number">]
        member _.Number(state: StringResourceState<'Length>, value: bool) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Number <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. **NOTE**: This is deprecated, use `numeric` instead. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#number-1">StringResource#number</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "number">]
        member _.Number(state: StringResourceState<'Length>, value: HashiCorp.Cdktf.IResolvable) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Number <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#numeric-1">StringResource#numeric</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "numeric">]
        member _.Numeric(state: StringResourceState<'Length>, value: bool) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Numeric <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#numeric-1">StringResource#numeric</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "numeric">]
        member _.Numeric(state: StringResourceState<'Length>, value: HashiCorp.Cdktf.IResolvable) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Numeric <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Supply your own list of special characters to use for string generation. This overrides the default character list in the special argument.  The `special` argument must still be set to true for any overwritten characters to be used in generation. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#override_special-1">StringResource#override_special</a>
        /// </summary>
        [<CustomOperation "override_special">]
        member _.OverrideSpecial(state: StringResourceState<'Length>, value: string) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.OverrideSpecial <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include special characters in the result. These are `!@#$%&*()-_=+[]{}<>:?`. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#special-1">StringResource#special</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "special">]
        member _.Special(state: StringResourceState<'Length>, value: bool) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Special <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include special characters in the result. These are `!@#$%&*()-_=+[]{}<>:?`. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#special-1">StringResource#special</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "special">]
        member _.Special(state: StringResourceState<'Length>, value: HashiCorp.Cdktf.IResolvable) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Special <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include uppercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#upper-1">StringResource#upper</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "upper">]
        member _.Upper(state: StringResourceState<'Length>, value: bool) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Upper <- value)
            state : StringResourceState<'Length>

        /// <summary>
        /// Include uppercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/string#upper-1">StringResource#upper</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "upper">]
        member _.Upper(state: StringResourceState<'Length>, value: HashiCorp.Cdktf.IResolvable) : StringResourceState<'Length> =
            state.assignments.Add(fun config -> config.Upper <- value)
            state : StringResourceState<'Length>

        member _.Run(state: StringResourceState<Present>) : random.StringResource.StringResource =
            let config = random.StringResource.StringResourceConfig()
            for setter in state.assignments do
                setter config
            random.StringResource.StringResource(StackContext.get (), logicalId, config)

        [<CompilerMessage("Random.stringResource: missing required arguments. Must call: length.", 9999, IsError = true)>]
        member _.Run(_: StringResourceState<_>) : random.StringResource.StringResource =
            Unchecked.defaultof<random.StringResource.StringResource>
