namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> = { assignments: ResizeArray<aws.EmrCluster.EmrClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster">aws_emr_cluster</a>.
    /// </summary>
    type EmrClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrClusterState<Missing, Missing, Missing>)

        member _.Zero(()) : EmrClusterState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrClusterState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#name-1">EmrCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrClusterState<Missing, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<Present, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmrClusterState<Present, 'ReleaseLabel, 'ServiceRole>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#release_label-1">EmrCluster#release_label</a>.
        /// </summary>
        [<CustomOperation "release_label">]
        member _.ReleaseLabel(state: EmrClusterState<'Name, Missing, 'ServiceRole>, value: string) : EmrClusterState<'Name, Present, 'ServiceRole> =
            state.assignments.Add(fun config -> config.ReleaseLabel <- value)
            ({ assignments = state.assignments } : EmrClusterState<'Name, Present, 'ServiceRole>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#service_role-1">EmrCluster#service_role</a>.
        /// </summary>
        [<CustomOperation "service_role">]
        member _.ServiceRole(state: EmrClusterState<'Name, 'ReleaseLabel, Missing>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, Present> =
            state.assignments.Add(fun config -> config.ServiceRole <- value)
            ({ assignments = state.assignments } : EmrClusterState<'Name, 'ReleaseLabel, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#additional_info-1">EmrCluster#additional_info</a>.
        /// </summary>
        [<CustomOperation "additional_info">]
        member _.AdditionalInfo(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.AdditionalInfo <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#applications-1">EmrCluster#applications</a>.
        /// </summary>
        [<CustomOperation "applications">]
        member _.Applications(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: seq<string>) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Applications <- (value |> Seq.toArray))
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#autoscaling_role-1">EmrCluster#autoscaling_role</a>.
        /// </summary>
        [<CustomOperation "autoscaling_role">]
        member _.AutoscalingRole(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.AutoscalingRole <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// auto_termination_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#auto_termination_policy-1">EmrCluster#auto_termination_policy</a>
        /// </summary>
        [<CustomOperation "auto_termination_policy">]
        member _.AutoTerminationPolicy(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterAutoTerminationPolicy) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.AutoTerminationPolicy <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// bootstrap_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#bootstrap_action-1">EmrCluster#bootstrap_action</a> Accepts: aws.IResolvable | aws.EmrCluster.EmrClusterBootstrapAction[]
        /// </summary>
        [<CustomOperation "bootstrap_action">]
        member _.BootstrapAction(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.BootstrapAction <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#configurations-1">EmrCluster#configurations</a>.
        /// </summary>
        [<CustomOperation "configurations">]
        member _.Configurations(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Configurations <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#configurations_json-1">EmrCluster#configurations_json</a>.
        /// </summary>
        [<CustomOperation "configurations_json">]
        member _.ConfigurationsJson(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.ConfigurationsJson <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// core_instance_fleet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#core_instance_fleet-1">EmrCluster#core_instance_fleet</a>
        /// </summary>
        [<CustomOperation "core_instance_fleet">]
        member _.CoreInstanceFleet(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterCoreInstanceFleet) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.CoreInstanceFleet <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// core_instance_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#core_instance_group-1">EmrCluster#core_instance_group</a>
        /// </summary>
        [<CustomOperation "core_instance_group">]
        member _.CoreInstanceGroup(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterCoreInstanceGroup) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.CoreInstanceGroup <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#custom_ami_id-1">EmrCluster#custom_ami_id</a>.
        /// </summary>
        [<CustomOperation "custom_ami_id">]
        member _.CustomAmiId(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.CustomAmiId <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#ebs_root_volume_size-1">EmrCluster#ebs_root_volume_size</a>.
        /// </summary>
        [<CustomOperation "ebs_root_volume_size">]
        member _.EbsRootVolumeSize(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: double) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.EbsRootVolumeSize <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// ec2_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#ec2_attributes-1">EmrCluster#ec2_attributes</a>
        /// </summary>
        [<CustomOperation "ec2_attributes">]
        member _.Ec2Attributes(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterEc2Attributes) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Ec2Attributes <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#id-1">EmrCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#keep_job_flow_alive_when_no_steps-1">EmrCluster#keep_job_flow_alive_when_no_steps</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "keep_job_flow_alive_when_no_steps">]
        member _.KeepJobFlowAliveWhenNoSteps(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: bool) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.KeepJobFlowAliveWhenNoSteps <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#keep_job_flow_alive_when_no_steps-1">EmrCluster#keep_job_flow_alive_when_no_steps</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "keep_job_flow_alive_when_no_steps">]
        member _.KeepJobFlowAliveWhenNoSteps(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.KeepJobFlowAliveWhenNoSteps <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// kerberos_attributes block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#kerberos_attributes-1">EmrCluster#kerberos_attributes</a>
        /// </summary>
        [<CustomOperation "kerberos_attributes">]
        member _.KerberosAttributes(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterKerberosAttributes) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.KerberosAttributes <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#list_steps_states-1">EmrCluster#list_steps_states</a>.
        /// </summary>
        [<CustomOperation "list_steps_states">]
        member _.ListStepsStates(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: seq<string>) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.ListStepsStates <- (value |> Seq.toArray))
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#log_encryption_kms_key_id-1">EmrCluster#log_encryption_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "log_encryption_kms_key_id">]
        member _.LogEncryptionKmsKeyId(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.LogEncryptionKmsKeyId <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#log_uri-1">EmrCluster#log_uri</a>.
        /// </summary>
        [<CustomOperation "log_uri">]
        member _.LogUri(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.LogUri <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// master_instance_fleet block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#master_instance_fleet-1">EmrCluster#master_instance_fleet</a>
        /// </summary>
        [<CustomOperation "master_instance_fleet">]
        member _.MasterInstanceFleet(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterMasterInstanceFleet) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.MasterInstanceFleet <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// master_instance_group block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#master_instance_group-1">EmrCluster#master_instance_group</a>
        /// </summary>
        [<CustomOperation "master_instance_group">]
        member _.MasterInstanceGroup(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: aws.EmrCluster.EmrClusterMasterInstanceGroup) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.MasterInstanceGroup <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#placement_group_config-1">EmrCluster#placement_group_config</a>. Accepts: aws.IResolvable | aws.EmrCluster.EmrClusterPlacementGroupConfig[]
        /// </summary>
        [<CustomOperation "placement_group_config">]
        member _.PlacementGroupConfig(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.PlacementGroupConfig <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#scale_down_behavior-1">EmrCluster#scale_down_behavior</a>.
        /// </summary>
        [<CustomOperation "scale_down_behavior">]
        member _.ScaleDownBehavior(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.ScaleDownBehavior <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#security_configuration-1">EmrCluster#security_configuration</a>.
        /// </summary>
        [<CustomOperation "security_configuration">]
        member _.SecurityConfiguration(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: string) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.SecurityConfiguration <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#step-1">EmrCluster#step</a>. Accepts: aws.IResolvable | aws.EmrCluster.EmrClusterStep[]
        /// </summary>
        [<CustomOperation "step">]
        member _.Step(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Step <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#step_concurrency_level-1">EmrCluster#step_concurrency_level</a>.
        /// </summary>
        [<CustomOperation "step_concurrency_level">]
        member _.StepConcurrencyLevel(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: double) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.StepConcurrencyLevel <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#tags-1">EmrCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: seq<string * string>) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#tags_all-1">EmrCluster#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: seq<string * string>) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#termination_protection-1">EmrCluster#termination_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_protection">]
        member _.TerminationProtection(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: bool) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.TerminationProtection <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#termination_protection-1">EmrCluster#termination_protection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "termination_protection">]
        member _.TerminationProtection(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.TerminationProtection <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#unhealthy_node_replacement-1">EmrCluster#unhealthy_node_replacement</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "unhealthy_node_replacement">]
        member _.UnhealthyNodeReplacement(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: bool) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.UnhealthyNodeReplacement <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#unhealthy_node_replacement-1">EmrCluster#unhealthy_node_replacement</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "unhealthy_node_replacement">]
        member _.UnhealthyNodeReplacement(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.UnhealthyNodeReplacement <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#visible_to_all_users-1">EmrCluster#visible_to_all_users</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "visible_to_all_users">]
        member _.VisibleToAllUsers(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: bool) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.VisibleToAllUsers <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emr_cluster#visible_to_all_users-1">EmrCluster#visible_to_all_users</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "visible_to_all_users">]
        member _.VisibleToAllUsers(state: EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>, value: HashiCorp.Cdktf.IResolvable) : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole> =
            state.assignments.Add(fun config -> config.VisibleToAllUsers <- value)
            state : EmrClusterState<'Name, 'ReleaseLabel, 'ServiceRole>

        member _.Run(state: EmrClusterState<Present, Present, Present>) : aws.EmrCluster.EmrCluster =
            let config = aws.EmrCluster.EmrClusterConfig()
            for setter in state.assignments do
                setter config
            aws.EmrCluster.EmrCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrCluster: missing required arguments. Must call: name, release_label, service_role.", 9999, IsError = true)>]
        member _.Run(_: EmrClusterState<_, _, _>) : aws.EmrCluster.EmrCluster =
            Unchecked.defaultof<aws.EmrCluster.EmrCluster>
