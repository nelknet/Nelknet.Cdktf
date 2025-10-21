namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DxLagState<'ConnectionsBandwidth, 'Location, 'Name> = { assignments: ResizeArray<aws.DxLag.DxLagConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag">aws_dx_lag</a>.
    /// </summary>
    type DxLagBuilder(logicalId: string) =
        member _.Yield(_: unit) : DxLagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxLagState<Missing, Missing, Missing>)

        member _.Zero(()) : DxLagState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DxLagState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#connections_bandwidth-1">DxLag#connections_bandwidth</a>.
        /// </summary>
        [<CustomOperation "connections_bandwidth">]
        member _.ConnectionsBandwidth(state: DxLagState<Missing, 'Location, 'Name>, value: string) : DxLagState<Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionsBandwidth <- value)
            ({ assignments = state.assignments } : DxLagState<Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#location-1">DxLag#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DxLagState<'ConnectionsBandwidth, Missing, 'Name>, value: string) : DxLagState<'ConnectionsBandwidth, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DxLagState<'ConnectionsBandwidth, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#name-1">DxLag#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DxLagState<'ConnectionsBandwidth, 'Location, Missing>, value: string) : DxLagState<'ConnectionsBandwidth, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DxLagState<'ConnectionsBandwidth, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#connection_id-1">DxLag#connection_id</a>.
        /// </summary>
        [<CustomOperation "connection_id">]
        member _.ConnectionId(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: string) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionId <- value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#force_destroy-1">DxLag#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: bool) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#force_destroy-1">DxLag#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#id-1">DxLag#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: string) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#provider_name-1">DxLag#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: string) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#tags-1">DxLag#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: seq<string * string>) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dx_lag#tags_all-1">DxLag#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DxLagState<'ConnectionsBandwidth, 'Location, 'Name>, value: seq<string * string>) : DxLagState<'ConnectionsBandwidth, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DxLagState<'ConnectionsBandwidth, 'Location, 'Name>

        member _.Run(state: DxLagState<Present, Present, Present>) : aws.DxLag.DxLag =
            let config = aws.DxLag.DxLagConfig()
            for setter in state.assignments do
                setter config
            aws.DxLag.DxLag(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dxLag: missing required arguments. Must call: connections_bandwidth, location, name.", 9999, IsError = true)>]
        member _.Run(_: DxLagState<_, _, _>) : aws.DxLag.DxLag =
            Unchecked.defaultof<aws.DxLag.DxLag>
