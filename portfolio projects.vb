<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Vaibhav Bawaskar Portfolio</title>
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Big+Shoulders+Inline&family=Podkova&family=Eater&family=Poppins&display=swap" rel="stylesheet">
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body {
            background-color: rgb(2, 2, 34);
            color: rgb(255, 255, 255);
            font-family: 'Poppins', sans-serif;
        }

        nav {
            display: flex;
            justify-content: space-between;
            align-items: center;
            height: 80px;
            background-color: rgb(28, 4, 41);
            padding: 0 20px;
        }

        nav .left {
            font-size: 1.5rem;
            color: white;
        }

        nav ul {
            display: flex;
            list-style: none;
        }

        nav ul li {
            margin: 0 15px;
            font-size: 1rem;
            color: white;
            cursor: pointer;
        }

        nav ul li:hover {
            color: #3498db;
        }

        .first {
            display: flex;
            justify-content: space-between;
            align-items: center;
            padding: 50px 20px;
        }

        .left {
            flex: 1;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .left img {
            width: 100%;
            max-width: 300px;
            height: auto;
            border-radius: 10px;
        }

        .right {
            flex: 2;
            color: white;
        }

        .right h2 {
            font-size: 3rem;
            margin-bottom: 10px;
        }

        .right h3 {
            font-size: 2.8rem;
            margin-bottom: 10px;
        }

        .purple {
            color: blueviolet;
        }

        #element {
            color: rgb(199, 30, 214);
            font-size: 2rem;
        }

        hr {
            border: 1px solid #3498db;
            margin: 8px 0;
        }

        .second {
            text-align: left;
            padding: 50px 20px;
            margin: 8vh;
        }

        .second h2 {
            font-size: 2.5rem;
            color: #fafbfc;
            font-weight: 600;
        }

        .second p {
            color: #dcdcdc;
            font-size: 1.1rem;
            margin-top: 10px;
        }

        .secondsection .box {
            background: rgb(9, 0, 0);
            height: 2px;
            margin: 6px 0;
            display: flex;
        }

        .text-gray {
            color: gray;
        }

        .tree-container {
            display: flex;
            flex-direction: column;
            align-items: center;
        }

        .work-node {
            display: flex;
            flex-direction: column;
            align-items: center;
            margin: 30px;
            position: relative;
        }

        .work-node img {
            width: 120px;
            border-radius: 50%;
            border: 2px solid white;
            margin-bottom: 10px;
        }

        .work-node .title {
            font-size: 1.25rem;
            color: white;
            font-weight: bold;
            margin-bottom: 5px;
        }

        .work-node .description {
            font-size: 1rem;
            color: #dcdcdc;
            text-align: center;
        }

        .line {
            height: 30px;
            width: 2px;
            background-color: #3498db;
            position: absolute;
            top: 100px;
            left: 50%;
            transform: translateX(-50%);
        }

        @media (max-width: 768px) {
            .first {
                flex-direction: column;
                text-align: center;
            }

            .left {
                margin-bottom: 20px;
            }

            .left img {
                max-width: 100%;
                height: auto;
            }

            nav ul {
                display: block;
                text-align: center;
            }

            nav ul li {
                margin: 10px 0;
            }
        }

        footer {
            background-color: rgba(70, 14, 75, 0.886);
            height: 70px;
            color: rgb(236, 233, 233);
            text-align: center;
            padding: 15px;
        }

        .footer {
            display: flex;
            justify-content: space-around;
            align-items: center;
            color: rgb(246, 244, 246);
            color: white;
        }

        .footer h3 {
            margin: 0;
        }
        .right .btn {
            padding: 8px;
            background-color: #010e17;
            color: white;
            border: 2px solid white;
            border-radius: 6px;
            font-size: 10px;
            cursor: pointer;

        }
        .footer {
  color: rgb(254, 250, 254); /* Change 'purple' to your desired color */
}
.footer a {
  color: rgb(252, 247, 252);
}

    </style>
</head>

<body>
    <nav>
        <div class="left">Vaibhav's Portfolio</div>
        <div>
            <ul>
                <li>Home</li>
                <li>About</li>
                <li>Services</li>
                <li>Projects</li>
                <li>Contact Me</li>
            </ul>
        </div>
    </nav>

    <main>
        <section class="first">
            <div class="right">
                <h2>Hi, my name is <span class="purple">Vaibhav Bawaskar</span></h2>
                <h3>And I am a passionate</h3>
                <div>Web Developer</div>
                <span id="element"></span>
                <div class="buttones"></div>
                <button class="btn">Dawnlod Resume</button>
                <button class="btn">Visit Github</button>
                
            </div>
            <div class="left">
                <img src="bd.png.jpg" alt="Vaibhav's background image">
            </div>
        </section>

        <section class="second">
            <hr>
            <div class="secondsection">
                <span class="text-gray">What I have done so far</span>
                <h2>Work Experience</h2>
                <div class="box"></div>
                <div class="tree-container">
                    <div class="work-node">
                        <img src="db.png.jpg" alt="HTML Developer Image">
                        <div class="title">HTML Developer (2012-2015)</div>
                        <div class="description">
                            Entry-Level/Junior HTML Developer, proficient in HTML5, CSS3, and responsive design.
                        </div>
                        <div class="line"></div>
                    </div>
                    <div class="work-node">
                        <img src="vb2.png" alt="Data Scientist Image">
                        <div class="title">Data Scientist (2015-2018)</div>
                        <div class="description">
                            Proficient in data collection, statistical analysis, and machine learning algorithms.
                        </div>
                        <div class="line"></div>
                    </div>
                    <div class="work-node">
                        <img src="pc.png" alt="Data Engineer Image">
                        <div class="title">Data Engineer (2018-2021)</div>
                        <div class="description">
                            Experienced in data pipeline development, data warehousing, and database management.
                        </div>
                        <div class="line"></div>
                    </div>
                    <div class="work-node">
                        <img src="vb.png.png" alt="Data Security Image">
                        <div class="title">Data Security (2021-2024)</div>
                        <div class="description">
                            Skilled in risk assessment, security policy, and ensuring data compliance.
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </main>

    <footer>
        <div class="footer">
            <h3>Vaibhav's Developer Portfolio</h3>
            <a href="https://www.instagram.com/vaibhavbawaskar_7?igsh=MzFmemRhcjNzMXdl">Instagram</a>
            <a href="https://www.linkedin.com/in/vaibhav-bawaskar-48a933319/">LinkedIn</a>
            <a href="https://github.com/VaibhavBawaskar/portfolio">Github</a>
            <a href="https://web.telegram.org/a/">Telegram </a>
            
            
        </div>
    </footer>

    <script src="https://unpkg.com/typed.js@2.1.0/dist/typed.umd.js"></script>
    <script>
        var typed = new Typed('#element', {
            strings: ['Web Developer,Designe', 'Data Scientist For', 'Data Base Engineer', 'Data Security Engineer'],
            typeSpeed: 50,
            loop: true,
        });
    </script>
</body>

</html>
