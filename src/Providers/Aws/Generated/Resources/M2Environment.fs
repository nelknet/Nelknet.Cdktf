namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type M2EnvironmentState<'EngineType, 'InstanceType, 'Name> = { assignments: ResizeArray<aws.M2Environment.M2EnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment">aws_m2_environment</a>.
    /// </summary>
    type M2EnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : M2EnvironmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : M2EnvironmentState<Missing, Missing, Missing>)

        member _.Zero(()) : M2EnvironmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : M2EnvironmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#engine_type-1">M2Environment#engine_type</a>.
        /// </summary>
        [<CustomOperation "engine_type">]
        member _.EngineType(state: M2EnvironmentState<Missing, 'InstanceType, 'Name>, value: string) : M2EnvironmentState<Present, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.EngineType <- value)
            ({ assignments = state.assignments } : M2EnvironmentState<Present, 'InstanceType, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#instance_type-1">M2Environment#instance_type</a>.
        /// </summary>
        [<CustomOperation "instance_type">]
        member _.InstanceType(state: M2EnvironmentState<'EngineType, Missing, 'Name>, value: string) : M2EnvironmentState<'EngineType, Present, 'Name> =
            state.assignments.Add(fun config -> config.InstanceType <- value)
            ({ assignments = state.assignments } : M2EnvironmentState<'EngineType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#name-1">M2Environment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: M2EnvironmentState<'EngineType, 'InstanceType, Missing>, value: string) : M2EnvironmentState<'EngineType, 'InstanceType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : M2EnvironmentState<'EngineType, 'InstanceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#apply_changes_during_maintenance_window-1">M2Environment#apply_changes_during_maintenance_window</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_changes_during_maintenance_window">]
        member _.ApplyChangesDuringMaintenanceWindow(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: bool) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ApplyChangesDuringMaintenanceWindow <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#apply_changes_during_maintenance_window-1">M2Environment#apply_changes_during_maintenance_window</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "apply_changes_during_maintenance_window">]
        member _.ApplyChangesDuringMaintenanceWindow(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ApplyChangesDuringMaintenanceWindow <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#description-1">M2Environment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: string) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#engine_version-1">M2Environment#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: string) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#force_update-1">M2Environment#force_update</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update">]
        member _.ForceUpdate(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: bool) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ForceUpdate <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#force_update-1">M2Environment#force_update</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_update">]
        member _.ForceUpdate(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ForceUpdate <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// high_availability_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#high_availability_config-1">M2Environment#high_availability_config</a> Accepts: aws.IResolvable | aws.M2Environment.M2EnvironmentHighAvailabilityConfig[]
        /// </summary>
        [<CustomOperation "high_availability_config">]
        member _.HighAvailabilityConfig(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.HighAvailabilityConfig <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#kms_key_id-1">M2Environment#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: string) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#preferred_maintenance_window-1">M2Environment#preferred_maintenance_window</a>.
        /// </summary>
        [<CustomOperation "preferred_maintenance_window">]
        member _.PreferredMaintenanceWindow(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: string) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.PreferredMaintenanceWindow <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#publicly_accessible-1">M2Environment#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: bool) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#publicly_accessible-1">M2Environment#publicly_accessible</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publicly_accessible">]
        member _.PubliclyAccessible(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.PubliclyAccessible <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#security_group_ids-1">M2Environment#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: seq<string>) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// storage_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#storage_configuration-1">M2Environment#storage_configuration</a> Accepts: aws.IResolvable | aws.M2Environment.M2EnvironmentStorageConfiguration[]
        /// </summary>
        [<CustomOperation "storage_configuration">]
        member _.StorageConfiguration(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.StorageConfiguration <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#subnet_ids-1">M2Environment#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: seq<string>) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#tags-1">M2Environment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: seq<string * string>) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/m2_environment#timeouts-1">M2Environment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: M2EnvironmentState<'EngineType, 'InstanceType, 'Name>, value: aws.M2Environment.M2EnvironmentTimeouts) : M2EnvironmentState<'EngineType, 'InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : M2EnvironmentState<'EngineType, 'InstanceType, 'Name>

        member _.Run(state: M2EnvironmentState<Present, Present, Present>) : aws.M2Environment.M2Environment =
            let config = aws.M2Environment.M2EnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.M2Environment.M2Environment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.m2Environment: missing required arguments. Must call: engine_type, instance_type, name.", 9999, IsError = true)>]
        member _.Run(_: M2EnvironmentState<_, _, _>) : aws.M2Environment.M2Environment =
            Unchecked.defaultof<aws.M2Environment.M2Environment>
