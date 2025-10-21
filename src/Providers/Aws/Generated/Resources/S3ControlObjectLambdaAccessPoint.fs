namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ControlObjectLambdaAccessPointState<'Configuration, 'Name> = { assignments: ResizeArray<aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPointConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point">aws_s3control_object_lambda_access_point</a>.
    /// </summary>
    type S3ControlObjectLambdaAccessPointBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ControlObjectLambdaAccessPointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlObjectLambdaAccessPointState<Missing, Missing>)

        member _.Zero(()) : S3ControlObjectLambdaAccessPointState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ControlObjectLambdaAccessPointState<Missing, Missing>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#configuration-1">S3ControlObjectLambdaAccessPoint#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: S3ControlObjectLambdaAccessPointState<Missing, 'Name>, value: aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPointConfiguration) : S3ControlObjectLambdaAccessPointState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            ({ assignments = state.assignments } : S3ControlObjectLambdaAccessPointState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#name-1">S3ControlObjectLambdaAccessPoint#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3ControlObjectLambdaAccessPointState<'Configuration, Missing>, value: string) : S3ControlObjectLambdaAccessPointState<'Configuration, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3ControlObjectLambdaAccessPointState<'Configuration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#account_id-1">S3ControlObjectLambdaAccessPoint#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: S3ControlObjectLambdaAccessPointState<'Configuration, 'Name>, value: string) : S3ControlObjectLambdaAccessPointState<'Configuration, 'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            state : S3ControlObjectLambdaAccessPointState<'Configuration, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#id-1">S3ControlObjectLambdaAccessPoint#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ControlObjectLambdaAccessPointState<'Configuration, 'Name>, value: string) : S3ControlObjectLambdaAccessPointState<'Configuration, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ControlObjectLambdaAccessPointState<'Configuration, 'Name>

        member _.Run(state: S3ControlObjectLambdaAccessPointState<Present, Present>) : aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPoint =
            let config = aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPointConfig()
            for setter in state.assignments do
                setter config
            aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPoint(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ControlObjectLambdaAccessPoint: missing required arguments. Must call: configuration, name.", 9999, IsError = true)>]
        member _.Run(_: S3ControlObjectLambdaAccessPointState<_, _>) : aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPoint =
            Unchecked.defaultof<aws.S3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPoint>
