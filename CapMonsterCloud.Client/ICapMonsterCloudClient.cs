﻿using System.Threading;
using System.Threading.Tasks;
using Zennolab.CapMonsterCloud.Requests;
using Zennolab.CapMonsterCloud.Responses;

namespace Zennolab.CapMonsterCloud
{
    /// <summary>
    /// CapMonsterCloud client
    /// </summary>
    public interface ICapMonsterCloudClient
    {
        /// <summary>
        /// Gets current amount of money on balance
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>Current amount of money</returns>
        /// <exception cref="GetBalanceException"></exception>
        Task<decimal> GetBalanceAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="ImageToTextRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 300ms to 6s period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<ImageToTextResponse>> SolveAsync(ImageToTextRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="RecaptchaV2Request.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<RecaptchaV2Response>> SolveAsync(RecaptchaV2Request task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="RecaptchaV2ProxylessRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<RecaptchaV2Response>> SolveAsync(RecaptchaV2ProxylessRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="RecaptchaV3ProxylessRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<RecaptchaV3Response>> SolveAsync(RecaptchaV3ProxylessRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="FunCaptchaRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 80 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<FunCaptchaResponse>> SolveAsync(FunCaptchaRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="FunCaptchaProxylessRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 80 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<FunCaptchaResponse>> SolveAsync(FunCaptchaProxylessRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="HCaptchaRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<HCaptchaResponse>> SolveAsync(HCaptchaRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="HCaptchaProxylessRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<HCaptchaResponse>> SolveAsync(HCaptchaProxylessRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="GeeTestRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 80 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<GeeTestResponse>> SolveAsync(GeeTestRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="GeeTestProxylessRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 80 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<GeeTestResponse>> SolveAsync(GeeTestProxylessRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="RecaptchaV2EnterpriseRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<RecaptchaV2EnterpriseResponse>> SolveAsync(RecaptchaV2EnterpriseRequest task, CancellationToken cancellationToken);

        /// <summary>
        /// Solve <see cref="RecaptchaV2EnterpriseProxylessRequest.TaskType"/> task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="cancellationToken"></param>
        /// <remarks>
        /// You will get response within 10 - 180 secs period depending on service workload.
        /// </remarks>
        /// <returns>Captcha recognition result</returns>
        Task<CaptchaResult<RecaptchaV2EnterpriseResponse>> SolveAsync(RecaptchaV2EnterpriseProxylessRequest task, CancellationToken cancellationToken);

    }
}
