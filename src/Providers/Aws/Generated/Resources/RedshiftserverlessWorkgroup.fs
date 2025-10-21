namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> = { assignments: ResizeArray<aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup">aws_redshiftserverless_workgroup</a>.
    /// </summary>
    type RedshiftserverlessWorkgroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftserverlessWorkgroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessWorkgroupState<Missing, Missing>)

        member _.Zero(()) : RedshiftserverlessWorkgroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RedshiftserverlessWorkgroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#namespace_name-1">RedshiftserverlessWorkgroup#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: RedshiftserverlessWorkgroupState<Missing, 'WorkgroupName>, value: string) : RedshiftserverlessWorkgroupState<Present, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessWorkgroupState<Present, 'WorkgroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#workgroup_name-1">RedshiftserverlessWorkgroup#workgroup_name</a>.
        /// </summary>
        [<CustomOperation "workgroup_name">]
        member _.WorkgroupName(state: RedshiftserverlessWorkgroupState<'NamespaceName, Missing>, value: string) : RedshiftserverlessWorkgroupState<'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.WorkgroupName <- value)
            ({ assignments = state.assignments } : RedshiftserverlessWorkgroupState<'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#base_capacity-1">RedshiftserverlessWorkgroup#base_capacity</a>.
        /// </summary>
        [<CustomOperation "base_capacity">]
        member _.BaseCapacity(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: double) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.BaseCapacity <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// config_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#config_parameter-1">RedshiftserverlessWorkgroup#config_parameter</a> Accepts: aws.IResolvable | aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroupConfigParameter[]
        /// </summary>
        [<CustomOperation "config_parameter">]
        member _.ConfigParameter(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: HashiCorp.Cdktf.IResolvable) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.ConfigParameter <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#enhanced_vpc_routing-1">RedshiftserverlessWorkgroup#enhanced_vpc_routing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_vpc_routing">]
        member _.EnhancedVpcRouting(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: bool) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.EnhancedVpcRouting <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#enhanced_vpc_routing-1">RedshiftserverlessWorkgroup#enhanced_vpc_routing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enhanced_vpc_routing">]
        member _.EnhancedVpcRouting(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: HashiCorp.Cdktf.IResolvable) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.EnhancedVpcRouting <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#id-1">RedshiftserverlessWorkgroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: string) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#max_capacity-1">RedshiftserverlessWorkgroup#max_capacity</a>.
        /// </summary>
        [<CustomOperation "max_capacity">]
        member _.MaxCapacity(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: double) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.MaxCapacity <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#port-1">RedshiftserverlessWorkgroup#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: double) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.Port <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// price_performance_target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#price_performance_target-1">RedshiftserverlessWorkgroup#price_performance_target</a>
        /// </summary>
        [<CustomOperation "price_performance_target">]
        member _.PricePerformanceTarget(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroupPricePerformanceTarget) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.PricePerformanceTarget <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#publicly_accessible-1">RedshiftserverlessWorkgroup#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: bool) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#publicly_accessible-1">RedshiftserverlessWorkgroup#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: HashiCorp.Cdktf.IResolvable) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#security_group_ids-1">RedshiftserverlessWorkgroup#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: seq<string>) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#subnet_ids-1">RedshiftserverlessWorkgroup#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: seq<string>) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#tags-1">RedshiftserverlessWorkgroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: seq<string * string>) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#tags_all-1">RedshiftserverlessWorkgroup#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: seq<string * string>) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#timeouts-1">RedshiftserverlessWorkgroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroupTimeouts) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshiftserverless_workgroup#track_name-1">RedshiftserverlessWorkgroup#track_name</a>.
        /// </summary>
        [<CustomOperation "track_name">]
        member _.TrackName(state: RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>, value: string) : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName> =
            state.assignments.Add(fun config -> config.TrackName <- value)
            state : RedshiftserverlessWorkgroupState<'NamespaceName, 'WorkgroupName>

        member _.Run(state: RedshiftserverlessWorkgroupState<Present, Present>) : aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroup =
            let config = aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroupConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftserverlessWorkgroup: missing required arguments. Must call: namespace_name, workgroup_name.", 9999, IsError = true)>]
        member _.Run(_: RedshiftserverlessWorkgroupState<_, _>) : aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroup =
            Unchecked.defaultof<aws.RedshiftserverlessWorkgroup.RedshiftserverlessWorkgroup>
