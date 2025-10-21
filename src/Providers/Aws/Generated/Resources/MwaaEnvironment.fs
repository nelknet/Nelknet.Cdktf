namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> = { assignments: ResizeArray<aws.MwaaEnvironment.MwaaEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment">aws_mwaa_environment</a>.
    /// </summary>
    type MwaaEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : MwaaEnvironmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MwaaEnvironmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MwaaEnvironmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MwaaEnvironmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#dag_s3_path-1">MwaaEnvironment#dag_s3_path</a>.
        /// </summary>
        [<CustomOperation "dag_s3_path">]
        member _.DagS3Path(state: MwaaEnvironmentState<Missing, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<Present, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.DagS3Path <- value)
            ({ assignments = state.assignments } : MwaaEnvironmentState<Present, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#execution_role_arn-1">MwaaEnvironment#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: MwaaEnvironmentState<'DagS3Path, Missing, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, Present, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            ({ assignments = state.assignments } : MwaaEnvironmentState<'DagS3Path, Present, 'Name, 'NetworkConfiguration, 'SourceBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#name-1">MwaaEnvironment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, Missing, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, Present, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, Present, 'NetworkConfiguration, 'SourceBucketArn>)

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#network_configuration-1">MwaaEnvironment#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, Missing, 'SourceBucketArn>, value: aws.MwaaEnvironment.MwaaEnvironmentNetworkConfiguration) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, Present, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            ({ assignments = state.assignments } : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, Present, 'SourceBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#source_bucket_arn-1">MwaaEnvironment#source_bucket_arn</a>.
        /// </summary>
        [<CustomOperation "source_bucket_arn">]
        member _.SourceBucketArn(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, Missing>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, Present> =
            state.assignments.Add(fun config -> config.SourceBucketArn <- value)
            ({ assignments = state.assignments } : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#airflow_configuration_options-1">MwaaEnvironment#airflow_configuration_options</a>.
        /// </summary>
        [<CustomOperation "airflow_configuration_options">]
        member _.AirflowConfigurationOptions(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: seq<string * string>) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.AirflowConfigurationOptions <- dict value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#airflow_version-1">MwaaEnvironment#airflow_version</a>.
        /// </summary>
        [<CustomOperation "airflow_version">]
        member _.AirflowVersion(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.AirflowVersion <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#endpoint_management-1">MwaaEnvironment#endpoint_management</a>.
        /// </summary>
        [<CustomOperation "endpoint_management">]
        member _.EndpointManagement(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.EndpointManagement <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#environment_class-1">MwaaEnvironment#environment_class</a>.
        /// </summary>
        [<CustomOperation "environment_class">]
        member _.EnvironmentClass(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.EnvironmentClass <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#id-1">MwaaEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#kms_key-1">MwaaEnvironment#kms_key</a>.
        /// </summary>
        [<CustomOperation "kms_key">]
        member _.KmsKey(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.KmsKey <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// logging_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#logging_configuration-1">MwaaEnvironment#logging_configuration</a>
        /// </summary>
        [<CustomOperation "logging_configuration">]
        member _.LoggingConfiguration(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: aws.MwaaEnvironment.MwaaEnvironmentLoggingConfiguration) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.LoggingConfiguration <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#max_webservers-1">MwaaEnvironment#max_webservers</a>.
        /// </summary>
        [<CustomOperation "max_webservers">]
        member _.MaxWebservers(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: double) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.MaxWebservers <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#max_workers-1">MwaaEnvironment#max_workers</a>.
        /// </summary>
        [<CustomOperation "max_workers">]
        member _.MaxWorkers(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: double) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.MaxWorkers <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#min_webservers-1">MwaaEnvironment#min_webservers</a>.
        /// </summary>
        [<CustomOperation "min_webservers">]
        member _.MinWebservers(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: double) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.MinWebservers <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#min_workers-1">MwaaEnvironment#min_workers</a>.
        /// </summary>
        [<CustomOperation "min_workers">]
        member _.MinWorkers(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: double) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.MinWorkers <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#plugins_s3_object_version-1">MwaaEnvironment#plugins_s3_object_version</a>.
        /// </summary>
        [<CustomOperation "plugins_s3_object_version">]
        member _.PluginsS3ObjectVersion(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.PluginsS3ObjectVersion <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#plugins_s3_path-1">MwaaEnvironment#plugins_s3_path</a>.
        /// </summary>
        [<CustomOperation "plugins_s3_path">]
        member _.PluginsS3Path(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.PluginsS3Path <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#requirements_s3_object_version-1">MwaaEnvironment#requirements_s3_object_version</a>.
        /// </summary>
        [<CustomOperation "requirements_s3_object_version">]
        member _.RequirementsS3ObjectVersion(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.RequirementsS3ObjectVersion <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#requirements_s3_path-1">MwaaEnvironment#requirements_s3_path</a>.
        /// </summary>
        [<CustomOperation "requirements_s3_path">]
        member _.RequirementsS3Path(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.RequirementsS3Path <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#schedulers-1">MwaaEnvironment#schedulers</a>.
        /// </summary>
        [<CustomOperation "schedulers">]
        member _.Schedulers(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: double) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.Schedulers <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#startup_script_s3_object_version-1">MwaaEnvironment#startup_script_s3_object_version</a>.
        /// </summary>
        [<CustomOperation "startup_script_s3_object_version">]
        member _.StartupScriptS3ObjectVersion(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.StartupScriptS3ObjectVersion <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#startup_script_s3_path-1">MwaaEnvironment#startup_script_s3_path</a>.
        /// </summary>
        [<CustomOperation "startup_script_s3_path">]
        member _.StartupScriptS3Path(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.StartupScriptS3Path <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#tags-1">MwaaEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: seq<string * string>) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#tags_all-1">MwaaEnvironment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: seq<string * string>) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#timeouts-1">MwaaEnvironment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: aws.MwaaEnvironment.MwaaEnvironmentTimeouts) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#webserver_access_mode-1">MwaaEnvironment#webserver_access_mode</a>.
        /// </summary>
        [<CustomOperation "webserver_access_mode">]
        member _.WebserverAccessMode(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.WebserverAccessMode <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mwaa_environment#weekly_maintenance_window_start-1">MwaaEnvironment#weekly_maintenance_window_start</a>.
        /// </summary>
        [<CustomOperation "weekly_maintenance_window_start">]
        member _.WeeklyMaintenanceWindowStart(state: MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>, value: string) : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn> =
            state.assignments.Add(fun config -> config.WeeklyMaintenanceWindowStart <- value)
            state : MwaaEnvironmentState<'DagS3Path, 'ExecutionRoleArn, 'Name, 'NetworkConfiguration, 'SourceBucketArn>

        member _.Run(state: MwaaEnvironmentState<Present, Present, Present, Present, Present>) : aws.MwaaEnvironment.MwaaEnvironment =
            let config = aws.MwaaEnvironment.MwaaEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.MwaaEnvironment.MwaaEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.mwaaEnvironment: missing required arguments. Must call: dag_s3_path, execution_role_arn, name, network_configuration, source_bucket_arn.", 9999, IsError = true)>]
        member _.Run(_: MwaaEnvironmentState<_, _, _, _, _>) : aws.MwaaEnvironment.MwaaEnvironment =
            Unchecked.defaultof<aws.MwaaEnvironment.MwaaEnvironment>
