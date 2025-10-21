namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn> = { assignments: ResizeArray<aws.RdsClusterActivityStream.RdsClusterActivityStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream">aws_rds_cluster_activity_stream</a>.
    /// </summary>
    type RdsClusterActivityStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsClusterActivityStreamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterActivityStreamState<Missing, Missing, Missing>)

        member _.Zero(()) : RdsClusterActivityStreamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsClusterActivityStreamState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream#kms_key_id-1">RdsClusterActivityStream#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RdsClusterActivityStreamState<Missing, 'Mode, 'ResourceArn>, value: string) : RdsClusterActivityStreamState<Present, 'Mode, 'ResourceArn> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            ({ assignments = state.assignments } : RdsClusterActivityStreamState<Present, 'Mode, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream#mode-1">RdsClusterActivityStream#mode</a>.
        /// </summary>
        [<CustomOperation "mode">]
        member _.Mode(state: RdsClusterActivityStreamState<'KmsKeyId, Missing, 'ResourceArn>, value: string) : RdsClusterActivityStreamState<'KmsKeyId, Present, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Mode <- value)
            ({ assignments = state.assignments } : RdsClusterActivityStreamState<'KmsKeyId, Present, 'ResourceArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream#resource_arn-1">RdsClusterActivityStream#resource_arn</a>.
        /// </summary>
        [<CustomOperation "resource_arn">]
        member _.ResourceArn(state: RdsClusterActivityStreamState<'KmsKeyId, 'Mode, Missing>, value: string) : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, Present> =
            state.assignments.Add(fun config -> config.ResourceArn <- value)
            ({ assignments = state.assignments } : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream#engine_native_audit_fields_included-1">RdsClusterActivityStream#engine_native_audit_fields_included</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "engine_native_audit_fields_included">]
        member _.EngineNativeAuditFieldsIncluded(state: RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn>, value: bool) : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn> =
            state.assignments.Add(fun config -> config.EngineNativeAuditFieldsIncluded <- value)
            state : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream#engine_native_audit_fields_included-1">RdsClusterActivityStream#engine_native_audit_fields_included</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "engine_native_audit_fields_included">]
        member _.EngineNativeAuditFieldsIncluded(state: RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn>, value: HashiCorp.Cdktf.IResolvable) : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn> =
            state.assignments.Add(fun config -> config.EngineNativeAuditFieldsIncluded <- value)
            state : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_cluster_activity_stream#id-1">RdsClusterActivityStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn>, value: string) : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsClusterActivityStreamState<'KmsKeyId, 'Mode, 'ResourceArn>

        member _.Run(state: RdsClusterActivityStreamState<Present, Present, Present>) : aws.RdsClusterActivityStream.RdsClusterActivityStream =
            let config = aws.RdsClusterActivityStream.RdsClusterActivityStreamConfig()
            for setter in state.assignments do
                setter config
            aws.RdsClusterActivityStream.RdsClusterActivityStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsClusterActivityStream: missing required arguments. Must call: kms_key_id, mode, resource_arn.", 9999, IsError = true)>]
        member _.Run(_: RdsClusterActivityStreamState<_, _, _>) : aws.RdsClusterActivityStream.RdsClusterActivityStream =
            Unchecked.defaultof<aws.RdsClusterActivityStream.RdsClusterActivityStream>
