namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PasswordState<'Length> = { assignments: ResizeArray<random.Password.PasswordConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password">random_password</a>.
    /// </summary>
    type PasswordBuilder(logicalId: string) =
        member _.Yield(_: unit) : PasswordState<Missing> =
            ({ assignments = ResizeArray() } : PasswordState<Missing>)

        member _.Zero(()) : PasswordState<Missing> =
            ({ assignments = ResizeArray() } : PasswordState<Missing>)

        /// <summary>
        /// The length of the string desired. The minimum value for length is 1 and, length must also be >= (`min_upper` + `min_lower` + `min_numeric` + `min_special`). Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#length-1">Password#length</a>
        /// </summary>
        [<CustomOperation "length">]
        member _.Length(state: PasswordState<Missing>, value: double) : PasswordState<Present> =
            state.assignments.Add(fun config -> config.Length <- value)
            ({ assignments = state.assignments } : PasswordState<Present>)

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#keepers-1">Password#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: PasswordState<'Length>, value: seq<string * string>) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include lowercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#lower-1">Password#lower</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "lower">]
        member _.Lower(state: PasswordState<'Length>, value: bool) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Lower <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include lowercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#lower-1">Password#lower</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "lower">]
        member _.Lower(state: PasswordState<'Length>, value: HashiCorp.Cdktf.IResolvable) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Lower <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Minimum number of lowercase alphabet characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#min_lower-1">Password#min_lower</a>
        /// </summary>
        [<CustomOperation "min_lower">]
        member _.MinLower(state: PasswordState<'Length>, value: double) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.MinLower <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Minimum number of numeric characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#min_numeric-1">Password#min_numeric</a>
        /// </summary>
        [<CustomOperation "min_numeric">]
        member _.MinNumeric(state: PasswordState<'Length>, value: double) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.MinNumeric <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Minimum number of special characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#min_special-1">Password#min_special</a>
        /// </summary>
        [<CustomOperation "min_special">]
        member _.MinSpecial(state: PasswordState<'Length>, value: double) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.MinSpecial <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Minimum number of uppercase alphabet characters in the result. Default value is `0`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#min_upper-1">Password#min_upper</a>
        /// </summary>
        [<CustomOperation "min_upper">]
        member _.MinUpper(state: PasswordState<'Length>, value: double) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.MinUpper <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. **NOTE**: This is deprecated, use `numeric` instead. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#number-1">Password#number</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "number">]
        member _.Number(state: PasswordState<'Length>, value: bool) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Number <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. **NOTE**: This is deprecated, use `numeric` instead. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#number-1">Password#number</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "number">]
        member _.Number(state: PasswordState<'Length>, value: HashiCorp.Cdktf.IResolvable) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Number <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#numeric-1">Password#numeric</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "numeric">]
        member _.Numeric(state: PasswordState<'Length>, value: bool) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Numeric <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include numeric characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#numeric-1">Password#numeric</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "numeric">]
        member _.Numeric(state: PasswordState<'Length>, value: HashiCorp.Cdktf.IResolvable) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Numeric <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Supply your own list of special characters to use for string generation. This overrides the default character list in the special argument.  The `special` argument must still be set to true for any overwritten characters to be used in generation. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#override_special-1">Password#override_special</a>
        /// </summary>
        [<CustomOperation "override_special">]
        member _.OverrideSpecial(state: PasswordState<'Length>, value: string) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.OverrideSpecial <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include special characters in the result. These are `!@#$%&*()-_=+[]{}<>:?`. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#special-1">Password#special</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "special">]
        member _.Special(state: PasswordState<'Length>, value: bool) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Special <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include special characters in the result. These are `!@#$%&*()-_=+[]{}<>:?`. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#special-1">Password#special</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "special">]
        member _.Special(state: PasswordState<'Length>, value: HashiCorp.Cdktf.IResolvable) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Special <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include uppercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#upper-1">Password#upper</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "upper">]
        member _.Upper(state: PasswordState<'Length>, value: bool) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Upper <- value)
            state : PasswordState<'Length>

        /// <summary>
        /// Include uppercase alphabet characters in the result. Default value is `true`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/password#upper-1">Password#upper</a> Accepts: boolean | random.IResolvable
        /// </summary>
        [<CustomOperation "upper">]
        member _.Upper(state: PasswordState<'Length>, value: HashiCorp.Cdktf.IResolvable) : PasswordState<'Length> =
            state.assignments.Add(fun config -> config.Upper <- value)
            state : PasswordState<'Length>

        member _.Run(state: PasswordState<Present>) : random.Password.Password =
            let config = random.Password.PasswordConfig()
            for setter in state.assignments do
                setter config
            random.Password.Password(StackContext.get (), logicalId, config)

        [<CompilerMessage("Random.password: missing required arguments. Must call: length.", 9999, IsError = true)>]
        member _.Run(_: PasswordState<_>) : random.Password.Password =
            Unchecked.defaultof<random.Password.Password>
