namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VerifiedaccessInstanceState = { assignments: ResizeArray<aws.VerifiedaccessInstance.VerifiedaccessInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance">aws_verifiedaccess_instance</a>.
    /// </summary>
    type VerifiedaccessInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : VerifiedaccessInstanceState =
            { assignments = ResizeArray() }

        member _.Zero(()) : VerifiedaccessInstanceState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#cidr_endpoints_custom_subdomain-1">VerifiedaccessInstance#cidr_endpoints_custom_subdomain</a>.
        /// </summary>
        [<CustomOperation "cidr_endpoints_custom_subdomain">]
        member _.CidrEndpointsCustomSubdomain(state: VerifiedaccessInstanceState, value: string) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.CidrEndpointsCustomSubdomain <- value)
            state : VerifiedaccessInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#description-1">VerifiedaccessInstance#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: VerifiedaccessInstanceState, value: string) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : VerifiedaccessInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#fips_enabled-1">VerifiedaccessInstance#fips_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fips_enabled">]
        member _.FipsEnabled(state: VerifiedaccessInstanceState, value: bool) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.FipsEnabled <- value)
            state : VerifiedaccessInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#fips_enabled-1">VerifiedaccessInstance#fips_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fips_enabled">]
        member _.FipsEnabled(state: VerifiedaccessInstanceState, value: HashiCorp.Cdktf.IResolvable) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.FipsEnabled <- value)
            state : VerifiedaccessInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#id-1">VerifiedaccessInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VerifiedaccessInstanceState, value: string) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VerifiedaccessInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#tags-1">VerifiedaccessInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: VerifiedaccessInstanceState, value: seq<string * string>) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : VerifiedaccessInstanceState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_instance#tags_all-1">VerifiedaccessInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: VerifiedaccessInstanceState, value: seq<string * string>) : VerifiedaccessInstanceState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : VerifiedaccessInstanceState

        member _.Run(state: VerifiedaccessInstanceState) : aws.VerifiedaccessInstance.VerifiedaccessInstance =
            let config = aws.VerifiedaccessInstance.VerifiedaccessInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.VerifiedaccessInstance.VerifiedaccessInstance(StackContext.get (), logicalId, config)
