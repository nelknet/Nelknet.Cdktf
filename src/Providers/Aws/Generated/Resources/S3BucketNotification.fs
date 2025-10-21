namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketNotificationState<'Bucket> = { assignments: ResizeArray<aws.S3BucketNotification.S3BucketNotificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification">aws_s3_bucket_notification</a>.
    /// </summary>
    type S3BucketNotificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketNotificationState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketNotificationState<Missing>)

        member _.Zero(()) : S3BucketNotificationState<Missing> =
            ({ assignments = ResizeArray() } : S3BucketNotificationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#bucket-1">S3BucketNotification#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketNotificationState<Missing>, value: string) : S3BucketNotificationState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketNotificationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#eventbridge-1">S3BucketNotification#eventbridge</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "eventbridge">]
        member _.Eventbridge(state: S3BucketNotificationState<'Bucket>, value: bool) : S3BucketNotificationState<'Bucket> =
            state.assignments.Add(fun config -> config.Eventbridge <- value)
            state : S3BucketNotificationState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#eventbridge-1">S3BucketNotification#eventbridge</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "eventbridge">]
        member _.Eventbridge(state: S3BucketNotificationState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketNotificationState<'Bucket> =
            state.assignments.Add(fun config -> config.Eventbridge <- value)
            state : S3BucketNotificationState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#id-1">S3BucketNotification#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketNotificationState<'Bucket>, value: string) : S3BucketNotificationState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketNotificationState<'Bucket>

        /// <summary>
        /// lambda_function block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#lambda_function-1">S3BucketNotification#lambda_function</a> Accepts: aws.IResolvable | aws.S3BucketNotification.S3BucketNotificationLambdaFunction[]
        /// </summary>
        [<CustomOperation "lambda_function">]
        member _.LambdaFunction(state: S3BucketNotificationState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketNotificationState<'Bucket> =
            state.assignments.Add(fun config -> config.LambdaFunction <- value)
            state : S3BucketNotificationState<'Bucket>

        /// <summary>
        /// queue block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#queue-1">S3BucketNotification#queue</a> Accepts: aws.IResolvable | aws.S3BucketNotification.S3BucketNotificationQueue[]
        /// </summary>
        [<CustomOperation "queue">]
        member _.Queue(state: S3BucketNotificationState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketNotificationState<'Bucket> =
            state.assignments.Add(fun config -> config.Queue <- value)
            state : S3BucketNotificationState<'Bucket>

        /// <summary>
        /// topic block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_notification#topic-1">S3BucketNotification#topic</a> Accepts: aws.IResolvable | aws.S3BucketNotification.S3BucketNotificationTopic[]
        /// </summary>
        [<CustomOperation "topic">]
        member _.Topic(state: S3BucketNotificationState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : S3BucketNotificationState<'Bucket> =
            state.assignments.Add(fun config -> config.Topic <- value)
            state : S3BucketNotificationState<'Bucket>

        member _.Run(state: S3BucketNotificationState<Present>) : aws.S3BucketNotification.S3BucketNotification =
            let config = aws.S3BucketNotification.S3BucketNotificationConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketNotification.S3BucketNotification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketNotification: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: S3BucketNotificationState<_>) : aws.S3BucketNotification.S3BucketNotification =
            Unchecked.defaultof<aws.S3BucketNotification.S3BucketNotification>
