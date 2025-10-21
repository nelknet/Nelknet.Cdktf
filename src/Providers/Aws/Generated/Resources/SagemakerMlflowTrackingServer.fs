namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> = { assignments: ResizeArray<aws.SagemakerMlflowTrackingServer.SagemakerMlflowTrackingServerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server">aws_sagemaker_mlflow_tracking_server</a>.
    /// </summary>
    type SagemakerMlflowTrackingServerBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerMlflowTrackingServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerMlflowTrackingServerState<Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerMlflowTrackingServerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerMlflowTrackingServerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#artifact_store_uri-1">SagemakerMlflowTrackingServer#artifact_store_uri</a>.
        /// </summary>
        [<CustomOperation "artifact_store_uri">]
        member _.ArtifactStoreUri(state: SagemakerMlflowTrackingServerState<Missing, 'RoleArn, 'TrackingServerName>, value: string) : SagemakerMlflowTrackingServerState<Present, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.ArtifactStoreUri <- value)
            ({ assignments = state.assignments } : SagemakerMlflowTrackingServerState<Present, 'RoleArn, 'TrackingServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#role_arn-1">SagemakerMlflowTrackingServer#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, Missing, 'TrackingServerName>, value: string) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, Present, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, Present, 'TrackingServerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#tracking_server_name-1">SagemakerMlflowTrackingServer#tracking_server_name</a>.
        /// </summary>
        [<CustomOperation "tracking_server_name">]
        member _.TrackingServerName(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, Missing>, value: string) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.TrackingServerName <- value)
            ({ assignments = state.assignments } : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#automatic_model_registration-1">SagemakerMlflowTrackingServer#automatic_model_registration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic_model_registration">]
        member _.AutomaticModelRegistration(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: bool) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.AutomaticModelRegistration <- value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#automatic_model_registration-1">SagemakerMlflowTrackingServer#automatic_model_registration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "automatic_model_registration">]
        member _.AutomaticModelRegistration(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: HashiCorp.Cdktf.IResolvable) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.AutomaticModelRegistration <- value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#id-1">SagemakerMlflowTrackingServer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: string) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#mlflow_version-1">SagemakerMlflowTrackingServer#mlflow_version</a>.
        /// </summary>
        [<CustomOperation "mlflow_version">]
        member _.MlflowVersion(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: string) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.MlflowVersion <- value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#tags-1">SagemakerMlflowTrackingServer#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: seq<string * string>) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#tags_all-1">SagemakerMlflowTrackingServer#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: seq<string * string>) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#tracking_server_size-1">SagemakerMlflowTrackingServer#tracking_server_size</a>.
        /// </summary>
        [<CustomOperation "tracking_server_size">]
        member _.TrackingServerSize(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: string) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.TrackingServerSize <- value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_mlflow_tracking_server#weekly_maintenance_window_start-1">SagemakerMlflowTrackingServer#weekly_maintenance_window_start</a>.
        /// </summary>
        [<CustomOperation "weekly_maintenance_window_start">]
        member _.WeeklyMaintenanceWindowStart(state: SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>, value: string) : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName> =
            state.assignments.Add(fun config -> config.WeeklyMaintenanceWindowStart <- value)
            state : SagemakerMlflowTrackingServerState<'ArtifactStoreUri, 'RoleArn, 'TrackingServerName>

        member _.Run(state: SagemakerMlflowTrackingServerState<Present, Present, Present>) : aws.SagemakerMlflowTrackingServer.SagemakerMlflowTrackingServer =
            let config = aws.SagemakerMlflowTrackingServer.SagemakerMlflowTrackingServerConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerMlflowTrackingServer.SagemakerMlflowTrackingServer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerMlflowTrackingServer: missing required arguments. Must call: artifact_store_uri, role_arn, tracking_server_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerMlflowTrackingServerState<_, _, _>) : aws.SagemakerMlflowTrackingServer.SagemakerMlflowTrackingServer =
            Unchecked.defaultof<aws.SagemakerMlflowTrackingServer.SagemakerMlflowTrackingServer>
