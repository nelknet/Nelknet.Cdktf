namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Wafv2IpSetState<'IpAddressVersion, 'Scope> = { assignments: ResizeArray<aws.Wafv2IpSet.Wafv2IpSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set">aws_wafv2_ip_set</a>.
    /// </summary>
    type Wafv2IpSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Wafv2IpSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2IpSetState<Missing, Missing>)

        member _.Zero(()) : Wafv2IpSetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Wafv2IpSetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#ip_address_version-1">Wafv2IpSet#ip_address_version</a>.
        /// </summary>
        [<CustomOperation "ip_address_version">]
        member _.IpAddressVersion(state: Wafv2IpSetState<Missing, 'Scope>, value: string) : Wafv2IpSetState<Present, 'Scope> =
            state.assignments.Add(fun config -> config.IpAddressVersion <- value)
            ({ assignments = state.assignments } : Wafv2IpSetState<Present, 'Scope>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#scope-1">Wafv2IpSet#scope</a>.
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: Wafv2IpSetState<'IpAddressVersion, Missing>, value: string) : Wafv2IpSetState<'IpAddressVersion, Present> =
            state.assignments.Add(fun config -> config.Scope <- value)
            ({ assignments = state.assignments } : Wafv2IpSetState<'IpAddressVersion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#addresses-1">Wafv2IpSet#addresses</a>.
        /// </summary>
        [<CustomOperation "addresses">]
        member _.Addresses(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: seq<string>) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.Addresses <- (value |> Seq.toArray))
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#description-1">Wafv2IpSet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: string) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#id-1">Wafv2IpSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: string) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#name-1">Wafv2IpSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: string) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#name_prefix-1">Wafv2IpSet#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: string) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#tags-1">Wafv2IpSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: seq<string * string>) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_ip_set#tags_all-1">Wafv2IpSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Wafv2IpSetState<'IpAddressVersion, 'Scope>, value: seq<string * string>) : Wafv2IpSetState<'IpAddressVersion, 'Scope> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Wafv2IpSetState<'IpAddressVersion, 'Scope>

        member _.Run(state: Wafv2IpSetState<Present, Present>) : aws.Wafv2IpSet.Wafv2IpSet =
            let config = aws.Wafv2IpSet.Wafv2IpSetConfig()
            for setter in state.assignments do
                setter config
            aws.Wafv2IpSet.Wafv2IpSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.wafv2IpSet: missing required arguments. Must call: ip_address_version, scope.", 9999, IsError = true)>]
        member _.Run(_: Wafv2IpSetState<_, _>) : aws.Wafv2IpSet.Wafv2IpSet =
            Unchecked.defaultof<aws.Wafv2IpSet.Wafv2IpSet>
